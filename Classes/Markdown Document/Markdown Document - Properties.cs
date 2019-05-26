using System;
using System.Collections.Generic;

//DOLATER prune namespace: DaanV2.Markdown
namespace DaanV2.Markdown {
    public partial class MarkdownDocument {
        /// <summary></summary>
        public List<ISection> Sections { get; set; }

        /// <summary></summary>
        public String Filepath { get; set; }
    }
}
