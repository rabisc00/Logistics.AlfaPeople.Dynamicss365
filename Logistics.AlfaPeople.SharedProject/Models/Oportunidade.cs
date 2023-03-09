﻿using Logistiscs.AlfaPeople.Models.BaseModels;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logistiscs.AlfaPeople.Models.Models
{
	public class Oportunidade : ModelCore
	{
		public Oportunidade(IOrganizationService serviceClient)
		{
			this.ServiceClient = serviceClient;
			this.LogicalName = "opportunity";
		}
	}
}