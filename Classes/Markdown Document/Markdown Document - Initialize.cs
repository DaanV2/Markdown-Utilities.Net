using System;
using System.Collections.Generic;

//DOLATER prune namespace: DaanV2.Markdown
namespace DaanV2.Markdown {
    ///DOLATER <summary> add description for class: MarkdownDocument</summary>
	[Serializable]
    public partial class MarkdownDocument {
        /// <summary>Creates a new instance of <see cref="MarkdownDocument"/></summary>
        public MarkdownDocument() {
            this.Sections = new List<ISection>();
            this.Filepath = String.Empty;
        }
    }
}
