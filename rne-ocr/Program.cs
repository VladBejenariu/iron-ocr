using IronOcr;

var ocr = new IronTesseract();

ocr.Language = OcrLanguage.EnglishBest;
// ocr.AddSecondaryLanguage(OcrLanguage.EnglishBest);


using (var ocrInput = new OcrInput())
{
    ocrInput.AddPdf("8.pdf");
    // Optionally Apply Filters if needed:
    // ocrInput.Rotate(90);
    ocrInput.Sharpen();
    ocrInput.Binarize();
    ocrInput.Contrast();
    ocrInput.Deskew();  // use only if image not straight
    ocrInput.DeNoise(); // use only if image contains digital noise

    var ocrResult = ocr.Read(ocrInput);
    Console.WriteLine("FISIER: ");
    Console.WriteLine(ocrResult.Text);
    Console.ReadLine();
}