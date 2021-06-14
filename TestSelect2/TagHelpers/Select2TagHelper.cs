using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestSelect2.Models;
using TestSelect2.Utilites;

namespace TestSelect2.TagHelpers
{
    public class Select2TagHelper : TagHelper
    {

        public EnumKind EnumKind { get; set; }
        public string UpdateFunction { get; set; }
        public string Model { get; set; }
        public bool? AllowNull { get; set; }
        public string vldid { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string htmlContent = "";
            if (AllowNull == true)
            {
                htmlContent = "<option value=null>Please Select</option>";

            }
            if (EnumKind.kind1 == EnumKind)
            {
                var enumValues = EnumHelper.ToEnumerable<EnumItems1>();
                foreach (var item in enumValues)
                {
                    htmlContent += $@"<option value={(int)item}>{item.ToString()}</option>";
                    Debug.WriteLine($"{(int)item}-{item.ToString()}");

                }

            }

            output.TagName = "select";
            if (vldid != "")
            {
                output.Attributes.SetAttribute("vldid", vldid);
            }
            output.Attributes.SetAttribute("data-placeholder", "Please Select");
            output.Attributes.SetAttribute("v-select2","");
            if (Model != "")
            {
                output.Attributes.SetAttribute("v-model", Model);
            }
            if (UpdateFunction != "")
            {
                output.Attributes.SetAttribute("v-on:update", UpdateFunction);

            }
            output.Content.SetHtmlContent(htmlContent);
            output.TagMode = TagMode.StartTagAndEndTag;
        }


    }


}