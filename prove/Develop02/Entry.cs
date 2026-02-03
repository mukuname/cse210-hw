using System;

public class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    public string GetEntryAsString()
    {
        return $"{_date} | {_prompt}\n{_response}";
    }

    public string GetSaveString()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    public static Entry FromSaveString(string line)
    {
        string[] parts = line.Split("|");
        return new Entry(parts[0], parts[1], parts[2]);
    }
}
