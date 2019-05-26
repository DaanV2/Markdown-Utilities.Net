using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DOLATER prune namespace: DaanV2.Markdown
namespace DaanV2.Markdown {
    ///DOLATER <summary> add description for class: MarkdownSectionIdentifier</summary>
	[Serializable]
    public enum MarkdownSectionIdentifier {
        RawText,
        Header,
        QuoteBlock,
        CodeBlock,
        Table,
        List,
        Link,
        Image,
        HTML,
        Line

    }
}
