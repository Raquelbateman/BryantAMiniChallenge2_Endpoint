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


// Endpoint that accepts 2 inputs, the users name and the time they woke up

app.MapGet("/wakeUp", (string name, string wakeUpTime) => {
    string result = "Hello " + name + ".. I see you woke up at " + wakeUpTime + ". Time is money hunnay!";
    return result;
});


// Endpoint that accepts 2 inputs and returns their sum

app.MapGet("/gimmeSum", (double a, double b) =>{

    double sum = a + b;

    string result = "The Sum of " + a + " and " + b + " is " + sum + "!";
    return result;

});

// Endpoint that accepts 2 numbers and tells you if the chosen numbers are either greater or lesser than one another

app.MapGet("/greaterOrLesser", (double a, double b) =>{
    
   // two string variables declared to store the comparisons
    string firstNum = "";
    string secondNum = "";

    
    // if statement used to compare firstResult with second

    if (a > b){
        firstNum = a + " is great than " + b + "!";
        secondNum = b + " is less than " + a + "!";
    }

    else if (b > a){
        firstNum = b + " is great than " + a + "!";
        secondNum = a + " is less than " + b + "!";   
    }

    else {
        firstNum = b + " is equal to " + a + "!";
        secondNum = a + " is equal to " + b + "!";
    }
    
    // newline character ("\n") - a special character used in strings and code to represent a new line
    string equation = firstNum + "\n" + secondNum;
    return equation;
});


app.Run();