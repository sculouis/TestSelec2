using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSelect2.TagHelpers
{
    public class Select2TagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string htmlContent = $@"
                        <option value='1'>項目一</option>
                        <option value='2'>項目二</option>
            ";
            output.TagName = "select";
            output.Attributes.SetAttribute("vldid", "select2");
            output.Attributes.SetAttribute("data-placeholder", "Please Select");
            output.Attributes.SetAttribute("v-select2","");
            output.Content.SetHtmlContent(htmlContent);
            output.TagMode = TagMode.StartTagAndEndTag;
        }


    }


}