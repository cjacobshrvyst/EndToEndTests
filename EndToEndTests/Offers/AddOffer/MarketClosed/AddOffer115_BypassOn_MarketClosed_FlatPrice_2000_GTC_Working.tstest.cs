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

    public class AddOffer105_BypassOn_MarketClosed_FlatPrice_2000_GTC_Working : BaseWebAiiTest
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
    
        [CodedStep(@"Click 'DeliveryLocationLakeFallsDiv'")]
        public void AddOffer38_BypassOn_MarketClosed_Basis_2000_GTC_Working_CodedStep()
        {
            // Click 'LakeFallsDiv1'
            ActiveBrowser.Window.SetFocus();
            Pages.TransactionsHRVYSTHEDGE.DeliveryLocationLakeFallsDiv.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementCenterAtWindowCenter);
            Pages.TransactionsHRVYSTHEDGE.DeliveryLocationLakeFallsDiv.MouseClick();
            
        }
    
        [CodedStep(@"Click 'DivcustomerName'")]
        public void AddOffer38_BypassOn_MarketClosed_Basis_2000_GTC_Working_CodedStep1()
        {
            // Click 'Div4'
            ActiveBrowser.Window.SetFocus();
            Pages.TransactionsHRVYSTHEDGE.DivcustomerName.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementCenterAtWindowCenter);
            Pages.TransactionsHRVYSTHEDGE.DivcustomerName.MouseClick();
            
        }
    
        [CodedStep(@"Enter text '1.2' in 'PostedBasisNumber'")]
        public void AddOffer38_BypassOn_MarketClosed_Basis_2000_GTC_Working_CodedStep2()
        {
            // Enter text '1.2' in 'PostedBasisNumber'
            Actions.SetText(Pages.TransactionsHRVYSTHEDGE.PostedBasisNumber, "");
            Pages.TransactionsHRVYSTHEDGE.PostedBasisNumber.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementCenterAtWindowCenter);
            ActiveBrowser.Window.SetFocus();
            Pages.TransactionsHRVYSTHEDGE.PostedBasisNumber.Focus();
            Pages.TransactionsHRVYSTHEDGE.PostedBasisNumber.MouseClick();
            Manager.Desktop.KeyBoard.TypeText("1.2", 50, 100, true);
            
        }
    
        [CodedStep(@"Enter text '' in 'PostedBasisNumber'")]
        public void AddOffer38_BypassOn_MarketClosed_Basis_2000_GTC_Working_CodedStep3()
        {
            // Enter text '' in 'PostedBasisNumber'
            Actions.SetText(Pages.TransactionsHRVYSTHEDGE.PostedBasisNumber, "");
            Pages.TransactionsHRVYSTHEDGE.PostedBasisNumber.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementCenterAtWindowCenter);
            ActiveBrowser.Window.SetFocus();
            Pages.TransactionsHRVYSTHEDGE.PostedBasisNumber.Focus();
            Pages.TransactionsHRVYSTHEDGE.PostedBasisNumber.MouseClick();
            Manager.Desktop.KeyBoard.TypeText("", 50, 100, true);
            Manager.Desktop.KeyBoard.TypeText("1.2",50,100,true);
            
        }
    
        [CodedStep(@"Enter text '5' in 'FlatPriceNumber'")]
        public void AddOffer115_BypassOn_MarketClosed_FlatPrice_2000_GTC_Working_CodedStep()
        {
            // Enter text '5' in 'FlatPriceNumber'
            Actions.SetText(Pages.TransactionsHRVYSTHEDGE.FlatPriceNumber, "");
            Pages.TransactionsHRVYSTHEDGE.FlatPriceNumber.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementCenterAtWindowCenter);
            ActiveBrowser.Window.SetFocus();
            Pages.TransactionsHRVYSTHEDGE.FlatPriceNumber.Focus();
            Pages.TransactionsHRVYSTHEDGE.FlatPriceNumber.MouseClick();
            Manager.Desktop.KeyBoard.TypeText("5..01", 50, 100, true);
            
        }
    }
}
