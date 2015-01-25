using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InterviewPractice.Sites.MVC.Startup))]
namespace InterviewPractice.Sites.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
