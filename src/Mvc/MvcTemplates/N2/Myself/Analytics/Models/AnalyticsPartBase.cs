﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using N2.Definitions;

namespace N2.Management.Myself.Analytics.Models
{
	public abstract class AnalyticsPartBase : ContentItem, IWebFormsAddable, IManagementHomePart
	{
		public override bool IsPage
		{
			get { return false; }
		}
	}
}
