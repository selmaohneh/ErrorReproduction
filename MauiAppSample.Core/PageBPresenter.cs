using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppSample.Core
{
    public class PageBPresenter
    {
        private readonly IView _pageA;
        private readonly IViewNavigator _viewNavigator;
        public IView PageB { get; }

        public PageBPresenter(IView pageB, IView pageA, IViewNavigator viewNavigator)
        {
            _pageA = pageA;
            _viewNavigator = viewNavigator;
            PageB = pageB;
            pageB.TheSampleButtonWasClicked += OnTheSampleButtonWasClicked;
        }

        private void OnTheSampleButtonWasClicked(object? sender, EventArgs e)
        {
            _viewNavigator.ShowView(_pageA);
        }
    }
}