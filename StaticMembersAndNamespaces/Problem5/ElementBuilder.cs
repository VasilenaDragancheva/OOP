using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    public class ElementBuilder
    {
	
        private string tagName;
        private List<string> attributes;
        private List<string> content;
     
        private string[] voidTags =
        {
            "area", "base", "br", "col", "embed", "hr", "img", "input","keygen", "link", "meta", "param", "source", "track", "wbr"
		};
		
        public ElementBuilder(string tagName)
        {
            this.TagName = tagName;
            this.attributes=new List<string>();
            this.content = new List<string>();
			
        }
        public string TagName 
        { 
            get
            {
                return this.tagName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Tag name can not be null!");
                }
                this.tagName = value;
            }
        }
        public void AddAttributes(string attribute, string value)
        {
		//asuming for some reasong somebody may want to add attribute with null value
		  if(string.IsNullOrEmpty(attribute))
          {
              throw new ArgumentNullException("Attribute can not be null");	
          }
          if (!string.IsNullOrEmpty(value))
          {
              this.attributes.Add(string.Format("{0}=\"{1}\"", attribute, value));
          }
        }
        public void AddContent(string content)
        {
			//does not throwing exception because it is not the case to
            if (this.voidTags.Contains(this.tagName.ToLower()))
            {
                throw new ArgumentException("Void tags does not have content");
            }
            if (content != null)
            {
                this.content.Add(content);
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.AppendFormat("<{0}", this.TagName);
            if (this.attributes.Count > 0)
            {
                foreach (String attribute in this.attributes)
                {
                    toString.AppendFormat(" {0}", attribute);
                }
            }
            toString.Append(">");
            bool notVoidTag = !this.voidTags.Contains(this.tagName);
            if (this.content.Count > 0)
            {
                foreach (string content in this.content)
                {
                    toString.AppendFormat("{0} ", content);
                }
            }
            if (notVoidTag)
            {
                toString.Append("</{0}>");
            }
            return toString.ToString();
    
        }

		public static string operator *(ElementBuilder element,int n)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n;i++ )
            {
                result.Append(element.ToString());
            }
            return result.ToString();
		}
		
    }
}
