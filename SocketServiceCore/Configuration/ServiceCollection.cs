using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace GiantSoft.SocketServiceCore.Configuration
{
	public class ServiceCollection : ConfigurationElementCollection
	{
		public Service this[int index]
		{
			get
			{
				return base.BaseGet(index) as Service;
			}
			set
			{
				if (base.BaseGet(index) != null)
				{
					base.BaseRemoveAt(index);
				}
				this.BaseAdd(index, value);
			}
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new Service();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((Service)element).ServiceName;
		}
	}
}
