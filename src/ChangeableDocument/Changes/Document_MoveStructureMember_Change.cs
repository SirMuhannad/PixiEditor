﻿using ChangeableDocument.Changeables;
using ChangeableDocument.ChangeInfos;

namespace ChangeableDocument.Changes
{
    internal class Document_MoveStructureMember_Change : Change<Document>
    {
        private Guid memberGuid;

        private Guid targetFolderGuid;
        private int targetFolderIndex;

        private Guid originalFolderGuid;
        private int originalFolderIndex;

        public Document_MoveStructureMember_Change(Guid memberGuid, Guid targetFolder, int targetFolderIndex)
        {
            this.memberGuid = memberGuid;
            this.targetFolderGuid = targetFolder;
            this.targetFolderIndex = targetFolderIndex;
        }

        protected override void DoInitialize(Document document)
        {
            var (member, curFolder) = document.FindChildAndParentOrThrow(memberGuid);
            originalFolderGuid = curFolder.GuidValue;
            originalFolderIndex = curFolder.Children.IndexOf(member);
        }

        private static void Move(Document document, Guid memberGuid, Guid targetFolderGuid, int targetIndex)
        {
            var targetFolder = (Folder)document.FindMemberOrThrow(targetFolderGuid);
            var (member, curFolder) = document.FindChildAndParentOrThrow(memberGuid);

            curFolder.Children.Remove(member);
            targetFolder.Children.Insert(targetIndex, member);
        }

        protected override IChangeInfo? DoApply(Document target)
        {
            Move(target, memberGuid, targetFolderGuid, targetFolderIndex);
            return new Document_MoveStructureMember_ChangeInfo() { GuidValue = memberGuid };
        }

        protected override IChangeInfo? DoRevert(Document target)
        {
            Move(target, memberGuid, originalFolderGuid, originalFolderIndex);
            return new Document_MoveStructureMember_ChangeInfo() { GuidValue = memberGuid };
        }
    }
}
