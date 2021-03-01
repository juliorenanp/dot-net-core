using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

public class ExemploMiddleWare
{

    // responsável por chamar o proximo middleware
    private readonly RequestDelegate _next;

    public ExemploMiddleWare(RequestDelegate next)
    {

        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine("Antes...");

        await _next(context);

        Console.WriteLine("Depois...");

    }

}