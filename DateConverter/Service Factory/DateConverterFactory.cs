using DateConverter.Core.Library;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace DateConverter.Core.Service_Factory
{
    public class DateConverterFactory
    {
        public static iDateConverter getDateConverterService()
        {
            IUnityContainer container = UnityFactory.getUnityContainer();
            var dateFunctions = container.Resolve<iDateFunctions>();
            var startDates = container.Resolve<iConversionStartDateData>();
            var nepaliDateData = container.Resolve<iNepaliDateData>();
            return new DateConverter.Core.Library.DateConverter(startDates, dateFunctions, nepaliDateData);
        }
    }
}
