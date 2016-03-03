﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace ERP.Web.Warehouses
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int WID=(Convert.ToInt32(strid));
					ShowInfo(WID);
				}
			}
		}
		
	private void ShowInfo(int WID)
	{
		ERP.BLL.Warehouses bll=new ERP.BLL.Warehouses();
		ERP.Model.Warehouses model=bll.GetModel(WID);
		this.lblWID.Text=model.WID.ToString();
		this.lblWName.Text=model.WName;
		this.lblWArea.Text=model.WArea.ToString();
		this.lblWAddress.Text=model.WAddress;
		this.lblWDescribe.Text=model.WDescribe;

	}


    }
}
