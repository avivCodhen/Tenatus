# Intrinio.SDK.Api.FundamentalsApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFundamentalById**](FundamentalsApi.md#getfundamentalbyid) | **GET** /fundamentals/{id} | Fundamental by ID
[**GetFundamentalReportedFinancials**](FundamentalsApi.md#getfundamentalreportedfinancials) | **GET** /fundamentals/{id}/reported_financials | Reported Financials
[**GetFundamentalStandardizedFinancials**](FundamentalsApi.md#getfundamentalstandardizedfinancials) | **GET** /fundamentals/{id}/standardized_financials | Standardized Financials
[**LookupFundamental**](FundamentalsApi.md#lookupfundamental) | **GET** /fundamentals/lookup/{identifier}/{statement_code}/{fiscal_year}/{fiscal_period} | Lookup Fundamental



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FundamentalsApi)

[//]: # (METHOD:GetFundamentalById)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.Fundamental)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:Fundamental.md)

[//]: # (OPERATION:GetFundamentalById_v2)

[//]: # (ENDPOINT:/fundamentals/{id})

[//]: # (DOCUMENT_LINK:FundamentalsApi.md#getfundamentalbyid)

<a name="getfundamentalbyid"></a>
## **GetFundamentalById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetFundamentalById_v2)

[//]: # (START_OVERVIEW)

> Fundamental GetFundamentalById (string id)

#### Fundamental by ID

Returns detailed fundamental data for the given `id`.

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class GetFundamentalByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var fundamentalsApi = new FundamentalsApi();
      var id = "fun_ge9LlE";  // string | The Intrinio ID for the Fundamental

      try
      {
        Fundamental result = fundamentalsApi.GetFundamentalById(id);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling FundamentalsApi.GetFundamentalById: " + e.Message );
      }
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | string| The Intrinio ID for the Fundamental |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**Fundamental**](Fundamental.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FundamentalsApi)

[//]: # (METHOD:GetFundamentalReportedFinancials)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseReportedFinancials)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseReportedFinancials.md)

[//]: # (OPERATION:GetFundamentalReportedFinancials_v2)

[//]: # (ENDPOINT:/fundamentals/{id}/reported_financials)

[//]: # (DOCUMENT_LINK:FundamentalsApi.md#getfundamentalreportedfinancials)

<a name="getfundamentalreportedfinancials"></a>
## **GetFundamentalReportedFinancials**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetFundamentalReportedFinancials_v2)

[//]: # (START_OVERVIEW)

> ApiResponseReportedFinancials GetFundamentalReportedFinancials (string id)

#### Reported Financials

Returns the As-Reported Financials directly from the financial statements of the XBRL filings from the company

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class GetFundamentalReportedFinancialsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var fundamentalsApi = new FundamentalsApi();
      var id = "AAPL-income_statement-2018-Q1";  // string | The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental

      try
      {
        ApiResponseReportedFinancials result = fundamentalsApi.GetFundamentalReportedFinancials(id);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling FundamentalsApi.GetFundamentalReportedFinancials: " + e.Message );
      }
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | string| The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseReportedFinancials**](ApiResponseReportedFinancials.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FundamentalsApi)

[//]: # (METHOD:GetFundamentalStandardizedFinancials)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStandardizedFinancials)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStandardizedFinancials.md)

[//]: # (OPERATION:GetFundamentalStandardizedFinancials_v2)

[//]: # (ENDPOINT:/fundamentals/{id}/standardized_financials)

[//]: # (DOCUMENT_LINK:FundamentalsApi.md#getfundamentalstandardizedfinancials)

<a name="getfundamentalstandardizedfinancials"></a>
## **GetFundamentalStandardizedFinancials**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetFundamentalStandardizedFinancials_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStandardizedFinancials GetFundamentalStandardizedFinancials (string id)

#### Standardized Financials

Returns professional-grade historical financial data. This data is standardized, cleansed and verified to ensure the highest quality data sourced directly from the XBRL financial statements. The primary purpose of standardized financials are to facilitate comparability across a single company’s fundamentals and across all companies' fundamentals.

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class GetFundamentalStandardizedFinancialsExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var fundamentalsApi = new FundamentalsApi();
      var id = "AAPL-income_statement-2018-Q1";  // string | The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental

      try
      {
        ApiResponseStandardizedFinancials result = fundamentalsApi.GetFundamentalStandardizedFinancials(id);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling FundamentalsApi.GetFundamentalStandardizedFinancials: " + e.Message );
      }
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | string| The Intrinio ID or lookup code (ticker-statement-year-period) for the Fundamental |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStandardizedFinancials**](ApiResponseStandardizedFinancials.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.FundamentalsApi)

[//]: # (METHOD:LookupFundamental)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.Fundamental)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:Fundamental.md)

[//]: # (OPERATION:LookupFundamental_v2)

[//]: # (ENDPOINT:/fundamentals/lookup/{identifier}/{statement_code}/{fiscal_year}/{fiscal_period})

[//]: # (DOCUMENT_LINK:FundamentalsApi.md#lookupfundamental)

<a name="lookupfundamental"></a>
## **LookupFundamental**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/LookupFundamental_v2)

[//]: # (START_OVERVIEW)

> Fundamental LookupFundamental (string identifier, string statementCode, int? fiscalYear, string fiscalPeriod)

#### Lookup Fundamental

Returns the Fundamental for the Company with the given `identifier` and with the given parameters

[//]: # (END_OVERVIEW)

### Example

[//]: # (START_CODE_EXAMPLE)

```csharp
using System;
using System.Diagnostics;
using Intrinio.SDK.Api;
using Intrinio.SDK.Client;
using Intrinio.SDK.Model;

namespace Example
{
  public class LookupFundamentalExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var fundamentalsApi = new FundamentalsApi();
      var identifier = "AAPL";  // string | A Company identifier (Ticker, CIK, LEI, Intrinio ID)
      var statementCode = "income_statement";  // string | The statement code
      var fiscalYear = 2017;  // int? | The fiscal year
      var fiscalPeriod = "FY";  // string | The fiscal period

      try
      {
        Fundamental result = fundamentalsApi.LookupFundamental(identifier, statementCode, fiscalYear, fiscalPeriod);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling FundamentalsApi.LookupFundamental: " + e.Message );
      }
    }
  }
}
```

[//]: # (END_CODE_EXAMPLE)

### Parameters

[//]: # (START_PARAMETERS)


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identifier** | string| A Company identifier (Ticker, CIK, LEI, Intrinio ID) |  &nbsp;
 **statementCode** | string| The statement code |  &nbsp;
 **fiscalYear** | int?| The fiscal year |  &nbsp;
 **fiscalPeriod** | string| The fiscal period |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**Fundamental**](Fundamental.md)

[//]: # (END_OPERATION)

