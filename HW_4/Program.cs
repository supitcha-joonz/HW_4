// See https://aka.ms/new-console-template for more information
using HW_4;

Console.WriteLine("############ HW-4 Abstract Class ############");

//Abtract สร้าง object ใหม่ไม่ได้
//var job = new Job("Joonz","Internship",50000m,7);
//var resWhoamI = job.WhoamI();
//var resTax = job.GetTax();

//Console.WriteLine($"Who Am I : {resWhoamI}");
//Console.WriteLine($"Get Tax : {resTax}");

Console.WriteLine("\n############ Doctor ###########");
var doctor = new Doctor("Love", "Doctor", 250000m, 7);
var docWhoamI = doctor.WhoamI();
var docTax = doctor.GetTax();
Console.WriteLine($"Who Am I : {docWhoamI}.");
Console.WriteLine($"Get Tax : {docTax} Bath.");

Console.WriteLine("\n############ Police ###########");
var police = new Police("Kit", "Police" , 12000m , 10);
var poWhoamI = police.WhoamI();
var poTax = police.GetTax();
Console.WriteLine($"Who Am I : {poWhoamI}.");
Console.WriteLine($"Get Tax : {poTax} Bath.");

Console.WriteLine("\n############ Teacher ###########");
var teacher = new Teacher("Top", "Teacher", 28500m, 5);
var teWhoamI = teacher.WhoamI();
var teTax = teacher.GetTax();
Console.WriteLine($"Who Am I : {teWhoamI}.");
Console.WriteLine($"Get Tax : {teTax} Bath.");

