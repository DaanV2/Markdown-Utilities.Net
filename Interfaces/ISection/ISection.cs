using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DOLATER prune namespace: DaanV2.Markdown
namespace DaanV2.Markdown {
    ///DOLATER <summary> add description for interface: ISection</summary>
    public interface ISection {
        ///DOLATER <summary></summary>
        MarkdownSectionIdentifier Identifier { get; set; }

        ///DOLATER <summary></summary>
        String Text { get; set; }
    }
}
