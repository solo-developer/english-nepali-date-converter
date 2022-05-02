using DateConverter.Core.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace DateConverter.Core.Service_Factory
{
    public class FiscalYearFactory
    {
        public static iFiscalYearFunctions getFiscalYearService()
        {
            IUnityContainer container = UnityFactory.getUnityContainer();
            var dateConverter = container.Resolve<iDateConverter>();
            var nepaliDateData = container.Resolve<iNepaliDateData>();
            return new FiscalYearFunctions(dateConverter, nepaliDateData);
        }
    }
}
