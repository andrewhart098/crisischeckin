using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrisisCheckinMobile.CustomRenderer
{
    class PaddedButton : Button
    {
        protected override SizeRequest OnSizeRequest(double widthConstraint, double heightConstraint)
        {
            var result = base.OnSizeRequest(widthConstraint, heightConstraint);

            return new SizeRequest(new Size(result.Request.Width + 20, result.Request.Height));
        }
    }
}
