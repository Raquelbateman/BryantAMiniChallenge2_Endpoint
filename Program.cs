var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


// Endpoint that accepts 2 inputs
app.MapGet("/wakeUp", (string name, string wakeUpTime) => {
    string result = "Hello " + name + ".. I see you woke up at " + wakeUpTime + ". Time is money hunnay!";
    return result;
});


// Endpoint that accepts 2 inputs
app.MapGet("/gimmeSum", (double a, double b) =>{

    double sum = a + b;
    string result = "The Sum of " + a + " and " + b + " is " + sum + "!";
    return result;

});

// Endpoint that accepts 2 numbers"

app.MapGet("/greaterOrLesser", (double a, double b) =>{
    
   
    string firstResult = "";
    string secondResult = "";

    
    if (a > b){
        firstResult = a + " is great than " + b + "!";
        secondResult = b + " is less than " + a + "!";
    }

    else if (b > a){
        firstResult = b + " is great than " + a + "!";
        secondResult = a + " is less than " + b + "!";   
    }

    else {
        firstResult= b + " is equal to " + a + "!";
        secondResult = a + " is equal to " + b + "!";
    }
    
    string equation = firstResult + "\n" + secondResult;
    return equation;
});


app.Run();