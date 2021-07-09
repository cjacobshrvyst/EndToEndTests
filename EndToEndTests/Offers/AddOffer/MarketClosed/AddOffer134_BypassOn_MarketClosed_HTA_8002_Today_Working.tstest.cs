using Telerik.TestStudio.Translators.Common;
using Telerik.TestingFramework.Controls.TelerikUI.Blazor;
using Telerik.TestingFramework.Controls.KendoUI.Angular;
using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
// using System.Windows.Forms;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace EndToEndTests
{

    public class AddOffer134_BypassOn_MarketClosed_HTA_8002_Today_Working : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here... 
        [CodedStep(@"Enter text '2021-07-01' in 'Text0'")]
        public void AddOffer_BypassOn_MarketOpen_HTA_5001_Working_CodedStep1()
        {
            // Enter text '2021-07-01' in 'Text0'
            Actions.SetText(Pages.TransactionsHRVYSTHEDGE.Text0, "");
            Pages.TransactionsHRVYSTHEDGE.Text0.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementCenterAtWindowCenter);
            ActiveBrowser.Window.SetFocus();
            Pages.TransactionsHRVYSTHEDGE.Text0.Focus();
            Pages.TransactionsHRVYSTHEDGE.Text0.MouseClick();
            string dt = DateTime.Now.Date.AddDays(1).ToString("yyyy-MM-dd");                
            Manager.Desktop.KeyBoard.TypeText(dt, 50, 100, true);
            
        }
    
        [CodedStep(@"Enter text '2021-07-30' in 'Text1'")]
        public void AddOffer_BypassOn_MarketOpen_HTA_5001_Working_CodedStep2()
        {
            // Enter text '2021-07-30' in 'Text1'
            Actions.SetText(Pages.TransactionsHRVYSTHEDGE.Text1, "");
            Pages.TransactionsHRVYSTHEDGE.Text1.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementCenterAtWindowCenter);
            ActiveBrowser.Window.SetFocus();
            Pages.TransactionsHRVYSTHEDGE.Text1.Focus();
            Pages.TransactionsHRVYSTHEDGE.Text1.MouseClick();
            string dt = DateTime.Now.Date.AddDays(30).ToString("yyyy-MM-dd");  
            Manager.Desktop.KeyBoard.TypeText(dt, 50, 100, true);
            
        }
        
        [CodedStep(@"Enter text '2,000' in 'QuantityText'")]
        public void AddOffer_BypassOn_MarketOpen_HTA_5001_Working_CodedStep3()
        {
            // Enter text '2,000' in 'QuantityText'
            Actions.SetText(Pages.TransactionsHRVYSTHEDGE.QuantityText, "");
            Pages.TransactionsHRVYSTHEDGE.QuantityText.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementCenterAtWindowCenter);
            ActiveBrowser.Window.SetFocus();
            Pages.TransactionsHRVYSTHEDGE.QuantityText.Focus();
            Pages.TransactionsHRVYSTHEDGE.QuantityText.MouseClick();
            Manager.Desktop.KeyBoard.TypeText("8,002", 50, 100, true);
            
        }
    
        [CodedStep(@"Enter text '754' in 'Text'")]
        public void AddOffer_BypassOn_MarketOpen_HTA_5001_Working_CodedStep4()
        {
            // Enter text '754' in 'Text'
            Actions.SetText(Pages.TransactionsHRVYSTHEDGE.Text2, "");
            Pages.TransactionsHRVYSTHEDGE.Text2.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementCenterAtWindowCenter);
            ActiveBrowser.Window.SetFocus();
            Pages.TransactionsHRVYSTHEDGE.Text2.Focus();
            Pages.TransactionsHRVYSTHEDGE.Text2.MouseClick();
            var dt = DateTime.Now;
            if (dt.Hour >= 14 || (dt.Hour==13 && dt.Minute>30))
                dt = dt.AddDays(1);
            string date = dt.Date.ToString("yyyy-MM-dd");
            Manager.Desktop.KeyBoard.TypeText(date, 50, 100, true);
                                    
        }
    }
}
