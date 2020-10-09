using System;
using System.Collections.Generic;
using System.Text;

namespace House
{
    class Outside : Location
    {
        private bool hot;


        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }

        public override string Description
        {
            get{
                return $"{base.Description}{(hot ? $"{NEW_LINE}It's very hot." : "")}";
            }
        }
    }
}
