// Copyright (c) Mark Nichols.  All Rights Reserved. 
//  Licensed under the MIT License.

//namespace BicepXray
//{
//    public class WriteXlsxFile
//    {
//        public static void WriteWorkbook(BicepTemplate template)
//        {
//            string nextTemplateName = "Root";

//            Workbook workbook = new Workbook("myWorkbook.xlsx", "Sheet1");

//            workbook.CurrentWorksheet.AddNextCell("Template Parent", Style.BasicStyles.Bold);
//            workbook.CurrentWorksheet.AddNextCell("Template", Style.BasicStyles.Bold);
//            workbook.CurrentWorksheet.AddNextCell("Scope", Style.BasicStyles.Bold);
//            workbook.CurrentWorksheet.GoToNextRow();

//            foreach (var childTmpl in template.Children)
//            {

//            }
//            workbook.CurrentWorksheet.AddNextCell("Template Parent", Style.BasicStyles.Bold);
//            workbook.CurrentWorksheet.AddNextCell("Template", Style.BasicStyles.Bold);
//            workbook.CurrentWorksheet.AddNextCell("Scope", Style.BasicStyles.Bold);
//            workbook.CurrentWorksheet.GoToNextRow();

//            //Root	createTestNetwork	C:\ProjectCode\VnetFunctions\test2.bicep	default

//            workbook.CurrentWorksheet.AddNextCell(nextTemplateName);
//            workbook.CurrentWorksheet.AddNextCell(template.Name);
//            workbook.CurrentWorksheet.AddNextCell(string.IsNullOrWhiteSpace(template.TargetScope) ? template.TargetScope : "default");



//            workbook.Save();                                                       // Save the workbook as myWorkbook.xlsx
//        }
//    }
//}
