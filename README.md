# 📘 C# SOAP API - Mathematical Operations 🧮

This project is a **SOAP API** developed in C# (.NET 6) that provides basic mathematical operations such as addition, subtraction, multiplication, and division. The API uses the `SoapCore NuGet Package` to define a SOAP-based service contract.

---

## 🌐 API Overview

### 🔗 URL Endpoints
- **Base URL:** `https://localhost:7220/`
- **WSDL:** `https://localhost:7220/Service.asmx`

### ✅ Supported Operations
1. ➕ **Addition**: Adds two numbers.
2. ➖ **Subtraction**: Subtracts the second number from the first.
3. ✖️ **Multiplication**: Multiplies two numbers.
4. ➗ **Division**: Divides the first number by the second (with error handling for division by zero).

---
## ⚙️ How to Run

1. **Clone the Repository**:  
   ```bash
   git clone https://github.com/Mates182/CS.SOAP-API.git
   ```
   ```bash
   cd CS.SOAP-API
   ```

2. **Run the API**:  
   - Using the .NET CLI:  
     ```bash
     dotnet run
     ```  
   - Or open the project in **Visual Studio Community 2022** and start the application.  

3. **Access the Service**:  
   - The application will run on `https://localhost:7220/`.  
   - Visit `https://localhost:7220/Service.asmx` to view the service WSDL or test endpoints.

## 🚀 Example Usage
You can use tools like `Postman`, or enter the direct request on a web browser

### ➕ Addition (`Sum`)
**Request**:  
`https://localhost:7220/Service.asmx/Sum?num1=4&num2=3`

**Response**:
```xml
<?xml version="1.0" encoding="utf-8"?>
<String xmlns="http://tempuri.org/">Sum of 4 plus 3 is: 7</String>
```

### ➖ Subtraction (`Subtract`)
**Request**:  
`https://localhost:7220/Service.asmx/Subtract?num1=10&num2=3`

**Response**:
```xml
<?xml version="1.0" encoding="utf-8"?>
<String xmlns="http://tempuri.org/">Difference of 10 minus 3 is: 7</String>
```

### ✖️ Multiplication (`Multiply`)
**Request**:  
`https://localhost:7220/Service.asmx/Multiply?num1=5&num2=6`

**Response**:
```xml
<?xml version="1.0" encoding="utf-8"?>
<String xmlns="http://tempuri.org/">Product of 5 multiplied by 6 is: 30</String>
```

### ➗ Division (`Divide`)
**Request**:  
`https://localhost:7220/Service.asmx/Divide?num1=10&num2=2`

**Response**:
```xml
<?xml version="1.0" encoding="utf-8"?>
<String xmlns="http://tempuri.org/">Division of 10 divided by 2 is: 5</String>
```

**🚫 Error Example (Division by Zero)**:  
**Request**:  
`https://localhost:7220/Service.asmx/Divide?num1=10&num2=0`

**Response**:
```xml
<?xml version="1.0" encoding="utf-8"?>
<String xmlns="http://tempuri.org/">Error: Division by zero is not allowed.</String>
```

---

## 🛠️ Technical Details

### 📄 Service Interface (`ISoapService`)
The service contract is defined in the `ISoapService` interface using `[ServiceContract]` and `[OperationContract]` attributes.

```csharp
[ServiceContract]
public interface ISoapService
{
    [OperationContract]
    string Sum(int num1, int num2);

    [OperationContract]
    string Subtract(int num1, int num2);

    [OperationContract]
    string Multiply(int num1, int num2);

    [OperationContract]
    string Divide(int num1, int num2);
}
```

### 💻 Implementation (`SoapService`)
Each method implements a mathematical operation and returns a descriptive string as the result.

```csharp
public class SoapService : ISoapService
{
    public string Sum(int num1, int num2)
    {
        return $"Sum of {num1} plus {num2} is: {num1 + num2}";
    }
    public string Subtract(int num1, int num2)
    {
        return $"Difference of {num1} minus {num2} is: {num1 - num2}";
    }

    public string Multiply(int num1, int num2)
    {
        return $"Product of {num1} multiplied by {num2} is: {num1 * num2}";
    }

    public string Divide(int num1, int num2)
    {
        if (num2 == 0)
        {
            return "Error: Division by zero is not allowed.";
        }
        return $"Division of {num1} divided by {num2} is: {(float) num1 / num2}";
    }
}
```

---

## 📝 Notes
- The application uses **HTTPS**. Ensure SSL/TLS settings are properly configured if deploying to production. 🔒
- This implementation provides only string responses. If needed, you can modify it to return more complex XML structures. 🛡️

---

🌟 **Enjoy using this simple SOAP API! :D** ✨