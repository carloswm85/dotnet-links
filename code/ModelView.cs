public virtual ActionResult Edit(int? id)
{
	IMessageModel vm = new RequestViewModel();
	try
	{
		CheckInitMessage(ref vm);
		var rvm = (RequestViewModel)vm;

		if (id.HasValue)
		{
			Solicitud requestDb = _operationsService.GetRequestItem(id.Value);
			rvm = _requestMapper.GetRequestItem(requestDb);
			rvm.SetRequestViewModel(requestId: id.Value, _adminService, _operationsService, _trackerMapper);
			ViewBag.Title = Resources.Request.EDIT_TITLE_UPDATE;
		}
		else
		{
			rvm.SetRequestViewModel(_adminService);
			ViewBag.Title = Resources.Request.EDIT_TITLE_DELIVERY;
		}
		return View(rvm);
	}
	catch (Exception ex)
	{
		string iError = LogHelper.LogError(ex, "Applicant", "Edit");
		vm.Message = string.Format(Resources.Global.TRY_CATCH_ERROR_MESSAGE, iError);
		vm.Type = MessageModel.MessageType.Error;
		return View(vm);
	}
}