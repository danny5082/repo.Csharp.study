var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Run(async (context) =>
{
    context.Response.ContentType = "rext/html; charset=utf-8";
    await context.Response.WriteAsync("<table border='1'>" +
        "<tr>" +
            "<td>지역</td>" +
            "<td>현재기온</td>" +
        "<tr>" +
        "<tr>" +
            "<td>서울</td>" +
            "<td>23</td>" +
        "<tr>" +
        "<table>");

});

app.Run();
