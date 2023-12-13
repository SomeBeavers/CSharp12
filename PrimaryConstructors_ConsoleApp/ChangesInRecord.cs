namespace PrimaryConstructors_ConsoleApp;

public class ChangesInRecord
{
	public void Test(RecordWithPrimaryConstructor pc)
	{
		var primaryConstructor = new RecordWithPrimaryConstructor(pc);
		new RecordWithPrimaryConstructor(String.Empty, 1,2);
	}
}

public record RecordWithPrimaryConstructor(string? Name, int Age, int i)
{
	public RecordWithPrimaryConstructor(RecordWithPrimaryConstructor record)
	{
	}
}