using System.Diagnostics.CodeAnalysis;
using ConsoleTableExt;

namespace Drinks_Info;

public class TableVisualisation
{
    public static void ShowTable<T>(List<T> tableData, [AllowNull] string tableName) where T : class
    {
        Console.Clear();

        if (tableName == null)
        {
            tableName = "";
        }

        Console.WriteLine("\n\n");

        ConsoleTableBuilder.From(tableData).WithColumn(tableName).WithFormat(ConsoleTableBuilderFormat.Alternative)
            .ExportAndWriteLine(TableAligntment.Center);
        Console.WriteLine("\n\n");
    }
}