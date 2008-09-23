using System;
using System.Collections.Generic;
using System.Text;
using PartCover.Browser.Api;
using PartCover.Browser.Features.Views;

namespace PartCover.Browser.Features
{
    public class FeatureViewCoverage
        : IFeature
        , IReportViewFactory
    {
        public void build(IServiceContainer container)
        {
            container.getService<IReportViewValve>().add(this);
        }

        public void destroy(IServiceContainer container)
        {
            container.getService<IReportViewValve>().remove(this);
        }

        public void attach(IServiceContainer container) { }

        public void detach(IServiceContainer container) { }

        public ReportView create()
        {
            return new CoverageView();
        }

        public string ViewName
        {
            get { return "View Coverage Details"; }
        }
    }
}
