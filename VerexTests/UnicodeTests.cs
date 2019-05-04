﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexBuilder;
using static RegexBuilder.Patterns.Unicode;
namespace RegexBuilderTests
{
    [TestClass]
    public class UnicodeTests
    {
        [TestMethod]
        public void TestPositiveCategories()
        {
            Assert.AreEqual(UppercaseLetter.Expression, UnicodeCategory(Categories.UppercaseLetter).Expression);
            Assert.AreEqual(LowercaseLetter.Expression, UnicodeCategory(Categories.LowercaseLetter).Expression);
            Assert.AreEqual(TitlecaseLetter.Expression, UnicodeCategory(Categories.TitlecaseLetter).Expression);
            Assert.AreEqual(ModifierLetter.Expression, UnicodeCategory(Categories.ModifierLetter).Expression);
            Assert.AreEqual(OtherLetter.Expression, UnicodeCategory(Categories.OtherLetter).Expression);
            Assert.AreEqual(Letter.Expression, UnicodeCategory(Categories.Letter).Expression);
            Assert.AreEqual(NonspacingMark.Expression, UnicodeCategory(Categories.NonspacingMark).Expression);
            Assert.AreEqual(SpacingCombiningMark.Expression, UnicodeCategory(Categories.SpacingCombiningMark).Expression);
            Assert.AreEqual(EnclosingMark.Expression, UnicodeCategory(Categories.EnclosingMark).Expression);
            Assert.AreEqual(Mark.Expression, UnicodeCategory(Categories.Mark).Expression);
            Assert.AreEqual(DecimalDigitNumber.Expression, UnicodeCategory(Categories.DecimalDigitNumber).Expression);
            Assert.AreEqual(LetterNumber.Expression, UnicodeCategory(Categories.LetterNumber).Expression);
            Assert.AreEqual(OtherNumber.Expression, UnicodeCategory(Categories.OtherNumber).Expression);
            Assert.AreEqual(Number.Expression, UnicodeCategory(Categories.Number).Expression);
            Assert.AreEqual(ConnectorPunctuation.Expression, UnicodeCategory(Categories.ConnectorPunctuation).Expression);
            Assert.AreEqual(DashPunctuation.Expression, UnicodeCategory(Categories.DashPunctuation).Expression);
            Assert.AreEqual(OpenPunctuation.Expression, UnicodeCategory(Categories.OpenPunctuation).Expression);
            Assert.AreEqual(ClosePunctuation.Expression, UnicodeCategory(Categories.ClosePunctuation).Expression);
            Assert.AreEqual(InitialquotePunctuation.Expression, UnicodeCategory(Categories.InitialquotePunctuation).Expression);
            Assert.AreEqual(FinalquotePunctuation.Expression, UnicodeCategory(Categories.FinalquotePunctuation).Expression);
            Assert.AreEqual(OtherPunctuation.Expression, UnicodeCategory(Categories.OtherPunctuation).Expression);
            Assert.AreEqual(Punctuation.Expression, UnicodeCategory(Categories.Punctuation).Expression);
            Assert.AreEqual(MathSymbol.Expression, UnicodeCategory(Categories.MathSymbol).Expression);
            Assert.AreEqual(CurrencySymbol.Expression, UnicodeCategory(Categories.CurrencySymbol).Expression);
            Assert.AreEqual(ModifierSymbol.Expression, UnicodeCategory(Categories.ModifierSymbol).Expression);
            Assert.AreEqual(OtherSymbol.Expression, UnicodeCategory(Categories.OtherSymbol).Expression);
            Assert.AreEqual(Patterns.Unicode.Symbol.Expression, UnicodeCategory(Categories.Symbol).Expression);
            Assert.AreEqual(SpaceSeparator.Expression, UnicodeCategory(Categories.SpaceSeparator).Expression);
            Assert.AreEqual(LineSeparator.Expression, UnicodeCategory(Categories.LineSeparator).Expression);
            Assert.AreEqual(ParagraphSeparator.Expression, UnicodeCategory(Categories.ParagraphSeparator).Expression);
            Assert.AreEqual(Separator.Expression, UnicodeCategory(Categories.Separator).Expression);
            Assert.AreEqual(Format.Expression, UnicodeCategory(Categories.Format).Expression);
            Assert.AreEqual(Surrogate.Expression, UnicodeCategory(Categories.Surrogate).Expression);
            Assert.AreEqual(PrivateUse.Expression, UnicodeCategory(Categories.PrivateUse).Expression);
            Assert.AreEqual(NotAssigned.Expression, UnicodeCategory(Categories.NotAssigned).Expression);
            Assert.AreEqual(OtherControl.Expression, UnicodeCategory(Categories.OtherControl).Expression);
            Assert.AreEqual(Control.Expression, UnicodeCategory(Categories.Control).Expression);
            Assert.AreEqual(BasicLatin.Expression, UnicodeCategory(Categories.BasicLatin).Expression);
            Assert.AreEqual(Latin_1Supplement.Expression, UnicodeCategory(Categories.Latin_1Supplement).Expression);
            Assert.AreEqual(LatinExtended_A.Expression, UnicodeCategory(Categories.LatinExtended_A).Expression);
            Assert.AreEqual(LatinExtended_B.Expression, UnicodeCategory(Categories.LatinExtended_B).Expression);
            Assert.AreEqual(IPAExtensions.Expression, UnicodeCategory(Categories.IPAExtensions).Expression);
            Assert.AreEqual(SpacingModifierLetters.Expression, UnicodeCategory(Categories.SpacingModifierLetters).Expression);
            Assert.AreEqual(CombiningDiacriticalMarks.Expression, UnicodeCategory(Categories.CombiningDiacriticalMarks).Expression);
            Assert.AreEqual(Greek.Expression, UnicodeCategory(Categories.Greek).Expression);
            Assert.AreEqual(GreekandCoptic.Expression, UnicodeCategory(Categories.GreekandCoptic).Expression);
            Assert.AreEqual(Cyrillic.Expression, UnicodeCategory(Categories.Cyrillic).Expression);
            Assert.AreEqual(CyrillicSupplement.Expression, UnicodeCategory(Categories.CyrillicSupplement).Expression);
            Assert.AreEqual(Armenian.Expression, UnicodeCategory(Categories.Armenian).Expression);
            Assert.AreEqual(Hebrew.Expression, UnicodeCategory(Categories.Hebrew).Expression);
            Assert.AreEqual(Arabic.Expression, UnicodeCategory(Categories.Arabic).Expression);
            Assert.AreEqual(Syriac.Expression, UnicodeCategory(Categories.Syriac).Expression);
            Assert.AreEqual(Thaana.Expression, UnicodeCategory(Categories.Thaana).Expression);
            Assert.AreEqual(Devanagari.Expression, UnicodeCategory(Categories.Devanagari).Expression);
            Assert.AreEqual(Bengali.Expression, UnicodeCategory(Categories.Bengali).Expression);
            Assert.AreEqual(Gurmukhi.Expression, UnicodeCategory(Categories.Gurmukhi).Expression);
            Assert.AreEqual(Gujarati.Expression, UnicodeCategory(Categories.Gujarati).Expression);
            Assert.AreEqual(Oriya.Expression, UnicodeCategory(Categories.Oriya).Expression);
            Assert.AreEqual(Tamil.Expression, UnicodeCategory(Categories.Tamil).Expression);
            Assert.AreEqual(Telugu.Expression, UnicodeCategory(Categories.Telugu).Expression);
            Assert.AreEqual(Kannada.Expression, UnicodeCategory(Categories.Kannada).Expression);
            Assert.AreEqual(Malayalam.Expression, UnicodeCategory(Categories.Malayalam).Expression);
            Assert.AreEqual(Sinhala.Expression, UnicodeCategory(Categories.Sinhala).Expression);
            Assert.AreEqual(Thai.Expression, UnicodeCategory(Categories.Thai).Expression);
            Assert.AreEqual(Lao.Expression, UnicodeCategory(Categories.Lao).Expression);
            Assert.AreEqual(Tibetan.Expression, UnicodeCategory(Categories.Tibetan).Expression);
            Assert.AreEqual(Myanmar.Expression, UnicodeCategory(Categories.Myanmar).Expression);
            Assert.AreEqual(Georgian.Expression, UnicodeCategory(Categories.Georgian).Expression);
            Assert.AreEqual(HangulJamo.Expression, UnicodeCategory(Categories.HangulJamo).Expression);
            Assert.AreEqual(Ethiopic.Expression, UnicodeCategory(Categories.Ethiopic).Expression);
            Assert.AreEqual(Cherokee.Expression, UnicodeCategory(Categories.Cherokee).Expression);
            Assert.AreEqual(UnifiedCanadianAboriginalSyllabics.Expression, UnicodeCategory(Categories.UnifiedCanadianAboriginalSyllabics).Expression);
            Assert.AreEqual(Ogham.Expression, UnicodeCategory(Categories.Ogham).Expression);
            Assert.AreEqual(Runic.Expression, UnicodeCategory(Categories.Runic).Expression);
            Assert.AreEqual(Tagalog.Expression, UnicodeCategory(Categories.Tagalog).Expression);
            Assert.AreEqual(Hanunoo.Expression, UnicodeCategory(Categories.Hanunoo).Expression);
            Assert.AreEqual(Buhid.Expression, UnicodeCategory(Categories.Buhid).Expression);
            Assert.AreEqual(Tagbanwa.Expression, UnicodeCategory(Categories.Tagbanwa).Expression);
            Assert.AreEqual(Khmer.Expression, UnicodeCategory(Categories.Khmer).Expression);
            Assert.AreEqual(Mongolian.Expression, UnicodeCategory(Categories.Mongolian).Expression);
            Assert.AreEqual(Limbu.Expression, UnicodeCategory(Categories.Limbu).Expression);
            Assert.AreEqual(TaiLe.Expression, UnicodeCategory(Categories.TaiLe).Expression);
            Assert.AreEqual(KhmerSymbols.Expression, UnicodeCategory(Categories.KhmerSymbols).Expression);
            Assert.AreEqual(PhoneticExtensions.Expression, UnicodeCategory(Categories.PhoneticExtensions).Expression);
            Assert.AreEqual(LatinExtendedAdditional.Expression, UnicodeCategory(Categories.LatinExtendedAdditional).Expression);
            Assert.AreEqual(GreekExtended.Expression, UnicodeCategory(Categories.GreekExtended).Expression);
            Assert.AreEqual(GeneralPunctuation.Expression, UnicodeCategory(Categories.GeneralPunctuation).Expression);
            Assert.AreEqual(SuperscriptsandSubscripts.Expression, UnicodeCategory(Categories.SuperscriptsandSubscripts).Expression);
            Assert.AreEqual(CurrencySymbols.Expression, UnicodeCategory(Categories.CurrencySymbols).Expression);
            Assert.AreEqual(CombiningDiacriticalMarksforSymbols.Expression, UnicodeCategory(Categories.CombiningDiacriticalMarksforSymbols).Expression);
            Assert.AreEqual(CombiningMarksforSymbols.Expression, UnicodeCategory(Categories.CombiningMarksforSymbols).Expression);
            Assert.AreEqual(LetterlikeSymbols.Expression, UnicodeCategory(Categories.LetterlikeSymbols).Expression);
            Assert.AreEqual(NumberForms.Expression, UnicodeCategory(Categories.NumberForms).Expression);
            Assert.AreEqual(Arrows.Expression, UnicodeCategory(Categories.Arrows).Expression);
            Assert.AreEqual(MathematicalOperators.Expression, UnicodeCategory(Categories.MathematicalOperators).Expression);
            Assert.AreEqual(MiscellaneousTechnical.Expression, UnicodeCategory(Categories.MiscellaneousTechnical).Expression);
            Assert.AreEqual(ControlPictures.Expression, UnicodeCategory(Categories.ControlPictures).Expression);
            Assert.AreEqual(OpticalCharacterRecognition.Expression, UnicodeCategory(Categories.OpticalCharacterRecognition).Expression);
            Assert.AreEqual(EnclosedAlphanumerics.Expression, UnicodeCategory(Categories.EnclosedAlphanumerics).Expression);
            Assert.AreEqual(BoxDrawing.Expression, UnicodeCategory(Categories.BoxDrawing).Expression);
            Assert.AreEqual(BlockElements.Expression, UnicodeCategory(Categories.BlockElements).Expression);
            Assert.AreEqual(GeometricShapes.Expression, UnicodeCategory(Categories.GeometricShapes).Expression);
            Assert.AreEqual(MiscellaneousSymbols.Expression, UnicodeCategory(Categories.MiscellaneousSymbols).Expression);
            Assert.AreEqual(Dingbats.Expression, UnicodeCategory(Categories.Dingbats).Expression);
            Assert.AreEqual(MiscellaneousMathematicalSymbols_A.Expression, UnicodeCategory(Categories.MiscellaneousMathematicalSymbols_A).Expression);
            Assert.AreEqual(SupplementalArrows_A.Expression, UnicodeCategory(Categories.SupplementalArrows_A).Expression);
            Assert.AreEqual(BraillePatterns.Expression, UnicodeCategory(Categories.BraillePatterns).Expression);
            Assert.AreEqual(SupplementalArrows_B.Expression, UnicodeCategory(Categories.SupplementalArrows_B).Expression);
            Assert.AreEqual(MiscellaneousMathematicalSymbols_B.Expression, UnicodeCategory(Categories.MiscellaneousMathematicalSymbols_B).Expression);
            Assert.AreEqual(SupplementalMathematicalOperators.Expression, UnicodeCategory(Categories.SupplementalMathematicalOperators).Expression);
            Assert.AreEqual(MiscellaneousSymbolsandArrows.Expression, UnicodeCategory(Categories.MiscellaneousSymbolsandArrows).Expression);
            Assert.AreEqual(CJKRadicalsSupplement.Expression, UnicodeCategory(Categories.CJKRadicalsSupplement).Expression);
            Assert.AreEqual(KangxiRadicals.Expression, UnicodeCategory(Categories.KangxiRadicals).Expression);
            Assert.AreEqual(IdeographicDescriptionCharacters.Expression, UnicodeCategory(Categories.IdeographicDescriptionCharacters).Expression);
            Assert.AreEqual(CJKSymbolsandPunctuation.Expression, UnicodeCategory(Categories.CJKSymbolsandPunctuation).Expression);
            Assert.AreEqual(Hiragana.Expression, UnicodeCategory(Categories.Hiragana).Expression);
            Assert.AreEqual(Katakana.Expression, UnicodeCategory(Categories.Katakana).Expression);
            Assert.AreEqual(Bopomofo.Expression, UnicodeCategory(Categories.Bopomofo).Expression);
            Assert.AreEqual(HangulCompatibilityJamo.Expression, UnicodeCategory(Categories.HangulCompatibilityJamo).Expression);
            Assert.AreEqual(Kanbun.Expression, UnicodeCategory(Categories.Kanbun).Expression);
            Assert.AreEqual(BopomofoExtended.Expression, UnicodeCategory(Categories.BopomofoExtended).Expression);
            Assert.AreEqual(KatakanaPhoneticExtensions.Expression, UnicodeCategory(Categories.KatakanaPhoneticExtensions).Expression);
            Assert.AreEqual(EnclosedCJKLettersandMonths.Expression, UnicodeCategory(Categories.EnclosedCJKLettersandMonths).Expression);
            Assert.AreEqual(CJKCompatibility.Expression, UnicodeCategory(Categories.CJKCompatibility).Expression);
            Assert.AreEqual(CJKUnifiedIdeographsExtensionA.Expression, UnicodeCategory(Categories.CJKUnifiedIdeographsExtensionA).Expression);
            Assert.AreEqual(YijingHexagramSymbols.Expression, UnicodeCategory(Categories.YijingHexagramSymbols).Expression);
            Assert.AreEqual(CJKUnifiedIdeographs.Expression, UnicodeCategory(Categories.CJKUnifiedIdeographs).Expression);
            Assert.AreEqual(YiSyllables.Expression, UnicodeCategory(Categories.YiSyllables).Expression);
            Assert.AreEqual(YiRadicals.Expression, UnicodeCategory(Categories.YiRadicals).Expression);
            Assert.AreEqual(HangulSyllables.Expression, UnicodeCategory(Categories.HangulSyllables).Expression);
            Assert.AreEqual(HighSurrogates.Expression, UnicodeCategory(Categories.HighSurrogates).Expression);
            Assert.AreEqual(HighPrivateUseSurrogates.Expression, UnicodeCategory(Categories.HighPrivateUseSurrogates).Expression);
            Assert.AreEqual(LowSurrogates.Expression, UnicodeCategory(Categories.LowSurrogates).Expression);
            Assert.AreEqual(PrivateUseArea.Expression, UnicodeCategory(Categories.PrivateUseArea).Expression);
            Assert.AreEqual(CJKCompatibilityIdeographs.Expression, UnicodeCategory(Categories.CJKCompatibilityIdeographs).Expression);
            Assert.AreEqual(LettericPresentationForms.Expression, UnicodeCategory(Categories.LettericPresentationForms).Expression);
            Assert.AreEqual(ArabicPresentationForms_A.Expression, UnicodeCategory(Categories.ArabicPresentationForms_A).Expression);
            Assert.AreEqual(VariationSelectors.Expression, UnicodeCategory(Categories.VariationSelectors).Expression);
            Assert.AreEqual(CombiningHalfMarks.Expression, UnicodeCategory(Categories.CombiningHalfMarks).Expression);
            Assert.AreEqual(CJKCompatibilityForms.Expression, UnicodeCategory(Categories.CJKCompatibilityForms).Expression);
            Assert.AreEqual(SmallFormVariants.Expression, UnicodeCategory(Categories.SmallFormVariants).Expression);
            Assert.AreEqual(ArabicPresentationForms_B.Expression, UnicodeCategory(Categories.ArabicPresentationForms_B).Expression);
            Assert.AreEqual(HalfwidthandFullwidthForms.Expression, UnicodeCategory(Categories.HalfwidthandFullwidthForms).Expression);
            Assert.AreEqual(Specials.Expression, UnicodeCategory(Categories.Specials).Expression);

        }

        [TestMethod]
        public void TestNegativeCategories()
        {
            Assert.AreEqual(NonUppercaseLetter.Expression, NegativeUnicodeCategory(Categories.UppercaseLetter).Expression);
            Assert.AreEqual(NonLowercaseLetter.Expression, NegativeUnicodeCategory(Categories.LowercaseLetter).Expression);
            Assert.AreEqual(NonTitlecaseLetter.Expression, NegativeUnicodeCategory(Categories.TitlecaseLetter).Expression);
            Assert.AreEqual(NonModifierLetter.Expression, NegativeUnicodeCategory(Categories.ModifierLetter).Expression);
            Assert.AreEqual(NonOtherLetter.Expression, NegativeUnicodeCategory(Categories.OtherLetter).Expression);
            Assert.AreEqual(NonLetter.Expression, NegativeUnicodeCategory(Categories.Letter).Expression);
            Assert.AreEqual(SpacingMark.Expression, NegativeUnicodeCategory(Categories.NonspacingMark).Expression);
            Assert.AreEqual(NonSpacingCombiningMark.Expression, NegativeUnicodeCategory(Categories.SpacingCombiningMark).Expression);
            Assert.AreEqual(NonEnclosingMark.Expression, NegativeUnicodeCategory(Categories.EnclosingMark).Expression);
            Assert.AreEqual(NonMark.Expression, NegativeUnicodeCategory(Categories.Mark).Expression);
            Assert.AreEqual(NonDecimalDigitNumber.Expression, NegativeUnicodeCategory(Categories.DecimalDigitNumber).Expression);
            Assert.AreEqual(NonLetterNumber.Expression, NegativeUnicodeCategory(Categories.LetterNumber).Expression);
            Assert.AreEqual(NonOtherNumber.Expression, NegativeUnicodeCategory(Categories.OtherNumber).Expression);
            Assert.AreEqual(NonNumber.Expression, NegativeUnicodeCategory(Categories.Number).Expression);
            Assert.AreEqual(NonConnectorPunctuation.Expression, NegativeUnicodeCategory(Categories.ConnectorPunctuation).Expression);
            Assert.AreEqual(NonDashPunctuation.Expression, NegativeUnicodeCategory(Categories.DashPunctuation).Expression);
            Assert.AreEqual(NonOpenPunctuation.Expression, NegativeUnicodeCategory(Categories.OpenPunctuation).Expression);
            Assert.AreEqual(NonClosePunctuation.Expression, NegativeUnicodeCategory(Categories.ClosePunctuation).Expression);
            Assert.AreEqual(NonInitialquotePunctuation.Expression, NegativeUnicodeCategory(Categories.InitialquotePunctuation).Expression);
            Assert.AreEqual(NonFinalquotePunctuation.Expression, NegativeUnicodeCategory(Categories.FinalquotePunctuation).Expression);
            Assert.AreEqual(NonOtherPunctuation.Expression, NegativeUnicodeCategory(Categories.OtherPunctuation).Expression);
            Assert.AreEqual(NonPunctuation.Expression, NegativeUnicodeCategory(Categories.Punctuation).Expression);
            Assert.AreEqual(NonMathSymbol.Expression, NegativeUnicodeCategory(Categories.MathSymbol).Expression);
            Assert.AreEqual(NonCurrencySymbol.Expression, NegativeUnicodeCategory(Categories.CurrencySymbol).Expression);
            Assert.AreEqual(NonModifierSymbol.Expression, NegativeUnicodeCategory(Categories.ModifierSymbol).Expression);
            Assert.AreEqual(NonOtherSymbol.Expression, NegativeUnicodeCategory(Categories.OtherSymbol).Expression);
            Assert.AreEqual(NonSymbol.Expression, NegativeUnicodeCategory(Categories.Symbol).Expression);
            Assert.AreEqual(NonSpaceSeparator.Expression, NegativeUnicodeCategory(Categories.SpaceSeparator).Expression);
            Assert.AreEqual(NonLineSeparator.Expression, NegativeUnicodeCategory(Categories.LineSeparator).Expression);
            Assert.AreEqual(NonParagraphSeparator.Expression, NegativeUnicodeCategory(Categories.ParagraphSeparator).Expression);
            Assert.AreEqual(NonSeparator.Expression, NegativeUnicodeCategory(Categories.Separator).Expression);
            Assert.AreEqual(NonFormat.Expression, NegativeUnicodeCategory(Categories.Format).Expression);
            Assert.AreEqual(NonSurrogate.Expression, NegativeUnicodeCategory(Categories.Surrogate).Expression);
            Assert.AreEqual(NonPrivateUse.Expression, NegativeUnicodeCategory(Categories.PrivateUse).Expression);
            Assert.AreEqual(Assigned.Expression, NegativeUnicodeCategory(Categories.NotAssigned).Expression);
            Assert.AreEqual(NonOtherControl.Expression, NegativeUnicodeCategory(Categories.OtherControl).Expression);
            Assert.AreEqual(NonControl.Expression, NegativeUnicodeCategory(Categories.Control).Expression);
            Assert.AreEqual(NonBasicLatin.Expression, NegativeUnicodeCategory(Categories.BasicLatin).Expression);
            Assert.AreEqual(NonLatin_1Supplement.Expression, NegativeUnicodeCategory(Categories.Latin_1Supplement).Expression);
            Assert.AreEqual(NonLatinExtended_A.Expression, NegativeUnicodeCategory(Categories.LatinExtended_A).Expression);
            Assert.AreEqual(NonLatinExtended_B.Expression, NegativeUnicodeCategory(Categories.LatinExtended_B).Expression);
            Assert.AreEqual(NonIPAExtensions.Expression, NegativeUnicodeCategory(Categories.IPAExtensions).Expression);
            Assert.AreEqual(NonSpacingModifierLetters.Expression, NegativeUnicodeCategory(Categories.SpacingModifierLetters).Expression);
            Assert.AreEqual(NonCombiningDiacriticalMarks.Expression, NegativeUnicodeCategory(Categories.CombiningDiacriticalMarks).Expression);
            Assert.AreEqual(NonGreek.Expression, NegativeUnicodeCategory(Categories.Greek).Expression);
            Assert.AreEqual(NonGreekandCoptic.Expression, NegativeUnicodeCategory(Categories.GreekandCoptic).Expression);
            Assert.AreEqual(NonCyrillic.Expression, NegativeUnicodeCategory(Categories.Cyrillic).Expression);
            Assert.AreEqual(NonCyrillicSupplement.Expression, NegativeUnicodeCategory(Categories.CyrillicSupplement).Expression);
            Assert.AreEqual(NonArmenian.Expression, NegativeUnicodeCategory(Categories.Armenian).Expression);
            Assert.AreEqual(NonHebrew.Expression, NegativeUnicodeCategory(Categories.Hebrew).Expression);
            Assert.AreEqual(NonArabic.Expression, NegativeUnicodeCategory(Categories.Arabic).Expression);
            Assert.AreEqual(NonSyriac.Expression, NegativeUnicodeCategory(Categories.Syriac).Expression);
            Assert.AreEqual(NonThaana.Expression, NegativeUnicodeCategory(Categories.Thaana).Expression);
            Assert.AreEqual(NonDevanagari.Expression, NegativeUnicodeCategory(Categories.Devanagari).Expression);
            Assert.AreEqual(NonBengali.Expression, NegativeUnicodeCategory(Categories.Bengali).Expression);
            Assert.AreEqual(NonGurmukhi.Expression, NegativeUnicodeCategory(Categories.Gurmukhi).Expression);
            Assert.AreEqual(NonGujarati.Expression, NegativeUnicodeCategory(Categories.Gujarati).Expression);
            Assert.AreEqual(NonOriya.Expression, NegativeUnicodeCategory(Categories.Oriya).Expression);
            Assert.AreEqual(NonTamil.Expression, NegativeUnicodeCategory(Categories.Tamil).Expression);
            Assert.AreEqual(NonTelugu.Expression, NegativeUnicodeCategory(Categories.Telugu).Expression);
            Assert.AreEqual(NonKannada.Expression, NegativeUnicodeCategory(Categories.Kannada).Expression);
            Assert.AreEqual(NonMalayalam.Expression, NegativeUnicodeCategory(Categories.Malayalam).Expression);
            Assert.AreEqual(NonSinhala.Expression, NegativeUnicodeCategory(Categories.Sinhala).Expression);
            Assert.AreEqual(NonThai.Expression, NegativeUnicodeCategory(Categories.Thai).Expression);
            Assert.AreEqual(NonLao.Expression, NegativeUnicodeCategory(Categories.Lao).Expression);
            Assert.AreEqual(NonTibetan.Expression, NegativeUnicodeCategory(Categories.Tibetan).Expression);
            Assert.AreEqual(NonMyanmar.Expression, NegativeUnicodeCategory(Categories.Myanmar).Expression);
            Assert.AreEqual(NonGeorgian.Expression, NegativeUnicodeCategory(Categories.Georgian).Expression);
            Assert.AreEqual(NonHangulJamo.Expression, NegativeUnicodeCategory(Categories.HangulJamo).Expression);
            Assert.AreEqual(NonEthiopic.Expression, NegativeUnicodeCategory(Categories.Ethiopic).Expression);
            Assert.AreEqual(NonCherokee.Expression, NegativeUnicodeCategory(Categories.Cherokee).Expression);
            Assert.AreEqual(NonUnifiedCanadianAboriginalSyllabics.Expression, NegativeUnicodeCategory(Categories.UnifiedCanadianAboriginalSyllabics).Expression);
            Assert.AreEqual(NonOgham.Expression, NegativeUnicodeCategory(Categories.Ogham).Expression);
            Assert.AreEqual(NonRunic.Expression, NegativeUnicodeCategory(Categories.Runic).Expression);
            Assert.AreEqual(NonTagalog.Expression, NegativeUnicodeCategory(Categories.Tagalog).Expression);
            Assert.AreEqual(NonHanunoo.Expression, NegativeUnicodeCategory(Categories.Hanunoo).Expression);
            Assert.AreEqual(NonBuhid.Expression, NegativeUnicodeCategory(Categories.Buhid).Expression);
            Assert.AreEqual(NonTagbanwa.Expression, NegativeUnicodeCategory(Categories.Tagbanwa).Expression);
            Assert.AreEqual(NonKhmer.Expression, NegativeUnicodeCategory(Categories.Khmer).Expression);
            Assert.AreEqual(NonMongolian.Expression, NegativeUnicodeCategory(Categories.Mongolian).Expression);
            Assert.AreEqual(NonLimbu.Expression, NegativeUnicodeCategory(Categories.Limbu).Expression);
            Assert.AreEqual(NonTaiLe.Expression, NegativeUnicodeCategory(Categories.TaiLe).Expression);
            Assert.AreEqual(NonKhmerSymbols.Expression, NegativeUnicodeCategory(Categories.KhmerSymbols).Expression);
            Assert.AreEqual(NonPhoneticExtensions.Expression, NegativeUnicodeCategory(Categories.PhoneticExtensions).Expression);
            Assert.AreEqual(NonLatinExtendedAdditional.Expression, NegativeUnicodeCategory(Categories.LatinExtendedAdditional).Expression);
            Assert.AreEqual(NonGreekExtended.Expression, NegativeUnicodeCategory(Categories.GreekExtended).Expression);
            Assert.AreEqual(NonGeneralPunctuation.Expression, NegativeUnicodeCategory(Categories.GeneralPunctuation).Expression);
            Assert.AreEqual(NonSuperscriptsandSubscripts.Expression, NegativeUnicodeCategory(Categories.SuperscriptsandSubscripts).Expression);
            Assert.AreEqual(NonCurrencySymbols.Expression, NegativeUnicodeCategory(Categories.CurrencySymbols).Expression);
            Assert.AreEqual(NonCombiningDiacriticalMarksforSymbols.Expression, NegativeUnicodeCategory(Categories.CombiningDiacriticalMarksforSymbols).Expression);
            Assert.AreEqual(NonCombiningMarksforSymbols.Expression, NegativeUnicodeCategory(Categories.CombiningMarksforSymbols).Expression);
            Assert.AreEqual(NonLetterlikeSymbols.Expression, NegativeUnicodeCategory(Categories.LetterlikeSymbols).Expression);
            Assert.AreEqual(NonNumberForms.Expression, NegativeUnicodeCategory(Categories.NumberForms).Expression);
            Assert.AreEqual(NonArrows.Expression, NegativeUnicodeCategory(Categories.Arrows).Expression);
            Assert.AreEqual(NonMathematicalOperators.Expression, NegativeUnicodeCategory(Categories.MathematicalOperators).Expression);
            Assert.AreEqual(NonMiscellaneousTechnical.Expression, NegativeUnicodeCategory(Categories.MiscellaneousTechnical).Expression);
            Assert.AreEqual(NonControlPictures.Expression, NegativeUnicodeCategory(Categories.ControlPictures).Expression);
            Assert.AreEqual(NonOpticalCharacterRecognition.Expression, NegativeUnicodeCategory(Categories.OpticalCharacterRecognition).Expression);
            Assert.AreEqual(NonEnclosedAlphanumerics.Expression, NegativeUnicodeCategory(Categories.EnclosedAlphanumerics).Expression);
            Assert.AreEqual(NonBoxDrawing.Expression, NegativeUnicodeCategory(Categories.BoxDrawing).Expression);
            Assert.AreEqual(NonBlockElements.Expression, NegativeUnicodeCategory(Categories.BlockElements).Expression);
            Assert.AreEqual(NonGeometricShapes.Expression, NegativeUnicodeCategory(Categories.GeometricShapes).Expression);
            Assert.AreEqual(NonMiscellaneousSymbols.Expression, NegativeUnicodeCategory(Categories.MiscellaneousSymbols).Expression);
            Assert.AreEqual(NonDingbats.Expression, NegativeUnicodeCategory(Categories.Dingbats).Expression);
            Assert.AreEqual(NonMiscellaneousMathematicalSymbols_A.Expression, NegativeUnicodeCategory(Categories.MiscellaneousMathematicalSymbols_A).Expression);
            Assert.AreEqual(NonSupplementalArrows_A.Expression, NegativeUnicodeCategory(Categories.SupplementalArrows_A).Expression);
            Assert.AreEqual(NonBraillePatterns.Expression, NegativeUnicodeCategory(Categories.BraillePatterns).Expression);
            Assert.AreEqual(NonSupplementalArrows_B.Expression, NegativeUnicodeCategory(Categories.SupplementalArrows_B).Expression);
            Assert.AreEqual(NonMiscellaneousMathematicalSymbols_B.Expression, NegativeUnicodeCategory(Categories.MiscellaneousMathematicalSymbols_B).Expression);
            Assert.AreEqual(NonSupplementalMathematicalOperators.Expression, NegativeUnicodeCategory(Categories.SupplementalMathematicalOperators).Expression);
            Assert.AreEqual(NonMiscellaneousSymbolsandArrows.Expression, NegativeUnicodeCategory(Categories.MiscellaneousSymbolsandArrows).Expression);
            Assert.AreEqual(NonCJKRadicalsSupplement.Expression, NegativeUnicodeCategory(Categories.CJKRadicalsSupplement).Expression);
            Assert.AreEqual(NonKangxiRadicals.Expression, NegativeUnicodeCategory(Categories.KangxiRadicals).Expression);
            Assert.AreEqual(NonIdeographicDescriptionCharacters.Expression, NegativeUnicodeCategory(Categories.IdeographicDescriptionCharacters).Expression);
            Assert.AreEqual(NonCJKSymbolsandPunctuation.Expression, NegativeUnicodeCategory(Categories.CJKSymbolsandPunctuation).Expression);
            Assert.AreEqual(NonHiragana.Expression, NegativeUnicodeCategory(Categories.Hiragana).Expression);
            Assert.AreEqual(NonKatakana.Expression, NegativeUnicodeCategory(Categories.Katakana).Expression);
            Assert.AreEqual(NonBopomofo.Expression, NegativeUnicodeCategory(Categories.Bopomofo).Expression);
            Assert.AreEqual(NonHangulCompatibilityJamo.Expression, NegativeUnicodeCategory(Categories.HangulCompatibilityJamo).Expression);
            Assert.AreEqual(NonKanbun.Expression, NegativeUnicodeCategory(Categories.Kanbun).Expression);
            Assert.AreEqual(NonBopomofoExtended.Expression, NegativeUnicodeCategory(Categories.BopomofoExtended).Expression);
            Assert.AreEqual(NonKatakanaPhoneticExtensions.Expression, NegativeUnicodeCategory(Categories.KatakanaPhoneticExtensions).Expression);
            Assert.AreEqual(NonEnclosedCJKLettersandMonths.Expression, NegativeUnicodeCategory(Categories.EnclosedCJKLettersandMonths).Expression);
            Assert.AreEqual(NonCJKCompatibility.Expression, NegativeUnicodeCategory(Categories.CJKCompatibility).Expression);
            Assert.AreEqual(NonCJKUnifiedIdeographsExtensionA.Expression, NegativeUnicodeCategory(Categories.CJKUnifiedIdeographsExtensionA).Expression);
            Assert.AreEqual(NonYijingHexagramSymbols.Expression, NegativeUnicodeCategory(Categories.YijingHexagramSymbols).Expression);
            Assert.AreEqual(NonCJKUnifiedIdeographs.Expression, NegativeUnicodeCategory(Categories.CJKUnifiedIdeographs).Expression);
            Assert.AreEqual(NonYiSyllables.Expression, NegativeUnicodeCategory(Categories.YiSyllables).Expression);
            Assert.AreEqual(NonYiRadicals.Expression, NegativeUnicodeCategory(Categories.YiRadicals).Expression);
            Assert.AreEqual(NonHangulSyllables.Expression, NegativeUnicodeCategory(Categories.HangulSyllables).Expression);
            Assert.AreEqual(NonHighSurrogates.Expression, NegativeUnicodeCategory(Categories.HighSurrogates).Expression);
            Assert.AreEqual(NonHighPrivateUseSurrogates.Expression, NegativeUnicodeCategory(Categories.HighPrivateUseSurrogates).Expression);
            Assert.AreEqual(NonLowSurrogates.Expression, NegativeUnicodeCategory(Categories.LowSurrogates).Expression);
            Assert.AreEqual(NonPrivateUseArea.Expression, NegativeUnicodeCategory(Categories.PrivateUseArea).Expression);
            Assert.AreEqual(NonCJKCompatibilityIdeographs.Expression, NegativeUnicodeCategory(Categories.CJKCompatibilityIdeographs).Expression);
            Assert.AreEqual(NonLettericPresentationForms.Expression, NegativeUnicodeCategory(Categories.LettericPresentationForms).Expression);
            Assert.AreEqual(NonArabicPresentationForms_A.Expression, NegativeUnicodeCategory(Categories.ArabicPresentationForms_A).Expression);
            Assert.AreEqual(NonVariationSelectors.Expression, NegativeUnicodeCategory(Categories.VariationSelectors).Expression);
            Assert.AreEqual(NonCombiningHalfMarks.Expression, NegativeUnicodeCategory(Categories.CombiningHalfMarks).Expression);
            Assert.AreEqual(NonCJKCompatibilityForms.Expression, NegativeUnicodeCategory(Categories.CJKCompatibilityForms).Expression);
            Assert.AreEqual(NonSmallFormVariants.Expression, NegativeUnicodeCategory(Categories.SmallFormVariants).Expression);
            Assert.AreEqual(NonArabicPresentationForms_B.Expression, NegativeUnicodeCategory(Categories.ArabicPresentationForms_B).Expression);
            Assert.AreEqual(NonHalfwidthandFullwidthForms.Expression, NegativeUnicodeCategory(Categories.HalfwidthandFullwidthForms).Expression);
            Assert.AreEqual(NonSpecials.Expression, NegativeUnicodeCategory(Categories.Specials).Expression);
        }

        [TestMethod]
        public void TestUnicodChars()
        {
            var c = UnicodeChar(222)[2, 0];
            Assert.AreEqual(c.Expression, @"\u00de{2,}");

            c = UnicodeChar(0xaf)[0, 0];
            Assert.AreEqual(c.Expression, @"\u00af*");
        }
    }
}
