﻿using System;

namespace Code.Core.BDFramework.SimpleGenCSharpCode
{
    public class MyField
    {
        private string CodeContent = "public [type] [field name];";

        public void SetType(Type type)
        {
            this.CodeContent=    this.CodeContent.Replace("[type]", type.FullName);
        }

        public void SetFieldName(string name)
        {
            this.CodeContent=   this.CodeContent.Replace("[field name]", name);
        }

        public void SetContent(string Content)
        {
            this.CodeContent=    this.CodeContent = Content;
        }

        override public string ToString()
        {
            return CodeContent;
        }
    }
}