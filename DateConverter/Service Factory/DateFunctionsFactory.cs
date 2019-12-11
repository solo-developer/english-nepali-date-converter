using DateConverter.Core.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace DateConverter.Core.Service_Factory
{
    public class DateFunctionsFactory
    {
        public static iDateFunctions getDateFunctionsService()
        {
            IUnityContainer container = UnityFactory.getUnityContainer();
            var nepaliDateData = container.Resolve<iNepaliDateData>();
            return new DateFunctions(nepaliDateData);
        }
    }
}
