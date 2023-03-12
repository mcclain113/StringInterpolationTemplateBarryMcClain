using System;
using System.Text;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var answer =($"{_date.Now,40:MMMM dd, yyyy}");
        Console.WriteLine(answer);
        return answer;
        
    }

    public string Number02()
    {
        var answer =_date.Now.ToString("yyyy.MM.dd");
        Console.WriteLine(answer);
        return answer;
    }

    public string Number03()
    {
        var answer =$"Day {_date.Now:dd} of {_date.Now:MMMM, yyyy}";
        Console.WriteLine(answer);
        return answer;
    }

    public string Number04()
    {
        var answer =$"Year: {_date.Now:yyyy}, Month: {_date.Now:MM}, Day: {_date.Now:dd}";
        Console.WriteLine(answer);
        return answer;
    }

    public string Number05()
    {
        var answer =$"{_date.Now,10:dddd}";
        Console.WriteLine(answer);
        return answer;
    }

    public string Number06()
    {
        var answer =$"{_date.Now,10:hh:mm tt}{_date.Now,10:dddd}";
        Console.WriteLine(answer);
        return answer;
    }

    public string Number07()
    {
        var answer =$"h:{_date.Now:hh}, m:{_date.Now:mm}, s:{_date.Now:ss}";
        Console.WriteLine(answer);
        return answer;
    }

    public string Number08()
    {
        var answer =_date.Now.ToString("yyyy.MM.dd.hh.mm.ss");
        Console.WriteLine(answer);
        return answer;
    }

    public string Number09()
    {
        var pi = Math.PI;
        var answer =$"{pi:C2}";
        return answer;
    }

    public string Number10()
    {
        var pi = Math.PI;
        var answer =$"{pi,10:N3}";
        return answer;
    }

    public string Number11()
    {

        string hexValue = string.Format("{0:x}", 2023);
        string upperHexValue = hexValue.ToUpper();

        return upperHexValue;
    }


}
