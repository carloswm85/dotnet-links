


public class MyModel
{
	public string Name { get; set; }
}

namespace Controllers
{
	public partial class MyController : BaseController
	{
		[HttpPost]
		public ActionResult MyAction(MyModel model)
		{
			// Code
		}
	}
}


