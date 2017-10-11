﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Nut.Models;

namespace Nut.Demo {
    public partial class MoneyToText : Form {
        public MoneyToText() {
            InitializeComponent();
            cmbLang.DataSource = new List<string>() { "en", "es", "fr", "ru", "tr", "ua", "id" };
            cmbCurrency.DataSource = new List<string>() { "usd", "eur", "rub", "try", "uah", "idr" };
        }

        private void btnMoneyToText_Click(object sender, EventArgs e) {
            var lang = cmbLang.SelectedValue.ToString();
            var currency = cmbCurrency.SelectedValue.ToString();
            var options = new Options {
                MainUnitNotConvertedToText = cbMainUnitNotConvertedToText.Checked,
                SubUnitNotConvertedToText = cbSubUnitNotConvertToText.Checked,
                MainUnitFirstCharUpper = cbMainUnitFirstCharUpper.Checked,
                SubUnitFirstCharUpper = cbSubUnitFirstCharUpper.Checked,
                CurrencyFirstCharUpper = cbCurrencyFirstCharUpper.Checked,
                SubUnitZeroNotDisplayed = cbSubUnitZeroNotIncluded.Checked,
            };
            var text = Convert.ToDecimal(txtNumber.Text, CultureInfo.CurrentCulture).ToText(currency, lang, options);
            txtResultText.Text = text;
        }
    }
}
