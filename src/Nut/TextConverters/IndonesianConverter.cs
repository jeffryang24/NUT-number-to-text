using System;
using Nut.Models;

namespace Nut.TextConverters
{
    public sealed class IndonesianConverter : BaseConverter
    {

        private static readonly Lazy<IndonesianConverter> Lazy = new Lazy<IndonesianConverter>(() => new IndonesianConverter());
        public static IndonesianConverter Instance => Lazy.Value;

        public override string CultureName => Culture.Indonesian;

        public IndonesianConverter()
        {
            Initialize();
        }

        private void Initialize()
        {
            NumberTexts.Add(0, new[] { "nol" });
            NumberTexts.Add(1, new[] { "satu" });
            NumberTexts.Add(2, new[] { "dua" });
            NumberTexts.Add(3, new[] { "tiga" });
            NumberTexts.Add(4, new[] { "empat" });
            NumberTexts.Add(5, new[] { "lima" });
            NumberTexts.Add(6, new[] { "enam" });
            NumberTexts.Add(7, new[] { "tujuh" });
            NumberTexts.Add(8, new[] { "delapan" });
            NumberTexts.Add(9, new[] { "sembilan" });
            NumberTexts.Add(10, new[] { "sepuluh" });
            NumberTexts.Add(11, new[] { "sebelas" });
            NumberTexts.Add(12, new[] { "dua belas" });
            NumberTexts.Add(13, new[] { "tiga belas" });
            NumberTexts.Add(14, new[] { "empat belas" });
            NumberTexts.Add(15, new[] { "lima belas" });
            NumberTexts.Add(16, new[] { "enam belas" });
            NumberTexts.Add(17, new[] { "tujuh belas" });
            NumberTexts.Add(18, new[] { "delapan belas" });
            NumberTexts.Add(19, new[] { "sembilan belas" });
            NumberTexts.Add(20, new[] { "dua puluh" });
            NumberTexts.Add(30, new[] { "tiga puluh" });
            NumberTexts.Add(40, new[] { "empat puluh" });
            NumberTexts.Add(50, new[] { "lima puluh" });
            NumberTexts.Add(60, new[] { "enam puluh" });
            NumberTexts.Add(70, new[] { "tujuh puluh" });
            NumberTexts.Add(80, new[] { "delapan puluh" });
            NumberTexts.Add(90, new[] { "sembilan puluh" });
            NumberTexts.Add(100, new[] { "seratus" });

            ScaleTexts.Add(1000000000, new[] { "miliar" });
            ScaleTexts.Add(1000000, new[] { "juta" });
            ScaleTexts.Add(1000, new[] { "ribu" });
        }

        protected override CurrencyModel GetCurrencyModel(string currency)
        {
            switch (currency)
            {
                case Currency.EUR:
                    return new CurrencyModel
                    {
                        Currency = currency,
                        Names = new[] { "euro", "euros" },
                        SubUnitCurrency = new BaseCurrencyModel { Names = new[] { "eurocent", "eurocents" } }
                    };
                case Currency.USD:
                    return new CurrencyModel
                    {
                        Currency = currency,
                        Names = new[] { "dollar", "dollars" },
                        SubUnitCurrency = new BaseCurrencyModel { Names = new[] { "cent", "cents" } }
                    };
                case Currency.RUB:
                    return new CurrencyModel
                    {
                        Currency = currency,
                        Names = new[] { "ruble", "rubles" },
                        SubUnitCurrency = new BaseCurrencyModel { Names = new[] { "kopek", "kopeks" } }
                    };
                case Currency.TRY:
                    return new CurrencyModel
                    {
                        Currency = currency,
                        Names = new[] { "turkish lira", "turkish lira" },
                        SubUnitCurrency = new BaseCurrencyModel { Names = new[] { "kurus", "kurus" } }
                    };
                case Currency.UAH:
                    return new CurrencyModel
                    {
                        Currency = currency,
                        Names = new[] { "ukrainian hryvnia", "ukrainian hryvnia" },
                        SubUnitCurrency = new BaseCurrencyModel { Names = new[] { "kopiyka", "kopiyky", "kopiyok" } }
                    };

                case Currency.IDR:
                    return new CurrencyModel
                    {
                        Currency = currency,
                        Names = new[] { "rupiah", "rupiah" },
                        SubUnitCurrency = new BaseCurrencyModel { Names = new[] { "" }} // No cent (SubUnitCurrency) in Rupiah
                    };
            }
            return null;
        }
    }
}