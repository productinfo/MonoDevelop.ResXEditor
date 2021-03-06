﻿namespace MonoDevelop.ResXEditor
{
    class ResXEditorStringsViewContent : ResXEditorListViewContent
	{
        protected override bool SkipNode(ResXNode node) => !(node.TypeName == typeof(System.String).AssemblyQualifiedName);
        protected override ResXNode GetPlaceholder() => new ResXNode(string.Empty, string.Empty, null, null);
        public override string TabPageLabel => "Strings";
	}
}
