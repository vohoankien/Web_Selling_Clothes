using MLModel1_ConsoleApp1;

MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
{
    Nội_dung_đánh_giá = @"Hàng không như mô tả, khá thất vọng.",
};

Console.WriteLine("Using model to make single prediction -- Comparing actual Số_sao with predicted Số_sao from sample data...\n\n");

Console.WriteLine($"Nội_dung_đánh_giá: {sampleData.Nội_dung_đánh_giá}");
Console.WriteLine($"Số_sao: {2}");  // Example of actual rating

// Predict all labels
var sortedScoresWithLabel = MLModel1.PredictAllLabels(sampleData);
Console.WriteLine($"{"Class",-40}{"Score",-20}");
Console.WriteLine($"{"-----",-40}{"-----",-20}");

foreach (var score in sortedScoresWithLabel)
{
    Console.WriteLine($"{score.Key,-40}{score.Value,-20}");
}

// Get the top predicted label
var topPrediction = sortedScoresWithLabel.OrderByDescending(x => x.Value).FirstOrDefault();
Console.WriteLine($"\nPredicted class: {topPrediction.Key} with score: {topPrediction.Value}");

Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();
