// Create a filtered element collector

var departmentList = new FilteredElementCollector(doc)
    .OfCategory(BuiltInCategory.OST_Rooms)
    .Cast<Room>()
    .GroupBy(room => room.get_Parameter(BuiltInParameter.ROOM_DEPARTMENT).AsString())
    .ToList();

/*
This codeblock is to check that the filtered element collector works

foreach (var department in departmentList)
{
	Console.WriteLine($"Department: {department.Key}");
}
*/

// Making a schedule for the first department
var firstGroup = departmentList[0];

Console.WriteLine($"The first department is: {firstGroup.Key}");
