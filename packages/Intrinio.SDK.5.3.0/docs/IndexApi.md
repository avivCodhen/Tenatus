# Intrinio.SDK.Api.IndexApi

All URIs are relative to *https://api-v2.intrinio.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAllEconomicIndices**](IndexApi.md#getalleconomicindices) | **GET** /indices/economic | All Economic Indices
[**GetAllSicIndices**](IndexApi.md#getallsicindices) | **GET** /indices/sic | All SIC Indices
[**GetAllStockMarketIndices**](IndexApi.md#getallstockmarketindices) | **GET** /indices/stock_market | All Stock Market Indices
[**GetEconomicIndexById**](IndexApi.md#geteconomicindexbyid) | **GET** /indices/economic/{identifier} | Lookup Economic Index
[**GetEconomicIndexDataPointNumber**](IndexApi.md#geteconomicindexdatapointnumber) | **GET** /indices/economic/{identifier}/data_point/{tag}/number | Data Point (Number) for an Economic Index
[**GetEconomicIndexDataPointText**](IndexApi.md#geteconomicindexdatapointtext) | **GET** /indices/economic/{identifier}/data_point/{tag}/text | Data Point (Text) for an Economic Index
[**GetEconomicIndexHistoricalData**](IndexApi.md#geteconomicindexhistoricaldata) | **GET** /indices/economic/{identifier}/historical_data/{tag} | Historical Data for an Economic Index
[**GetSicIndexById**](IndexApi.md#getsicindexbyid) | **GET** /indices/sic/{identifier} | Lookup SIC Index
[**GetSicIndexDataPointNumber**](IndexApi.md#getsicindexdatapointnumber) | **GET** /indices/sic/{identifier}/data_point/{tag}/number | Data Point (Number) for an SIC Index
[**GetSicIndexDataPointText**](IndexApi.md#getsicindexdatapointtext) | **GET** /indices/sic/{identifier}/data_point/{tag}/text | Data Point (Text) for an SIC Index
[**GetSicIndexHistoricalData**](IndexApi.md#getsicindexhistoricaldata) | **GET** /indices/sic/{identifier}/historical_data/{tag} | Historical Data for an SIC Index
[**GetStockMarketIndexById**](IndexApi.md#getstockmarketindexbyid) | **GET** /indices/stock_market/{identifier} | Lookup Stock Market Index
[**GetStockMarketIndexDataPointNumber**](IndexApi.md#getstockmarketindexdatapointnumber) | **GET** /indices/stock_market/{identifier}/data_point/{tag}/number | Data Point (Number) for Stock Market Index
[**GetStockMarketIndexDataPointText**](IndexApi.md#getstockmarketindexdatapointtext) | **GET** /indices/stock_market/{identifier}/data_point/{tag}/text | Data Point (Text) for Stock Market Index
[**GetStockMarketIndexHistoricalData**](IndexApi.md#getstockmarketindexhistoricaldata) | **GET** /indices/stock_market/{identifier}/historical_data/{tag} | Historical Data for Stock Market Index
[**SearchEconomicIndices**](IndexApi.md#searcheconomicindices) | **GET** /indices/economic/search | Search Economic Indices
[**SearchSicIndices**](IndexApi.md#searchsicindices) | **GET** /indices/sic/search | Search SIC Indices
[**SearchStockMarketsIndices**](IndexApi.md#searchstockmarketsindices) | **GET** /indices/stock_market/search | Search Stock Market Indices



[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetAllEconomicIndices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseEconomicIndices)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseEconomicIndices.md)

[//]: # (OPERATION:GetAllEconomicIndices_v2)

[//]: # (ENDPOINT:/indices/economic)

[//]: # (DOCUMENT_LINK:IndexApi.md#getalleconomicindices)

<a name="getalleconomicindices"></a>
## **GetAllEconomicIndices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllEconomicIndices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseEconomicIndices GetAllEconomicIndices (int? pageSize = null, string nextPage = null)

#### All Economic Indices


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
  public class GetAllEconomicIndicesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var indexApi = new IndexApi();
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseEconomicIndices result = indexApi.GetAllEconomicIndices(pageSize, nextPage);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling IndexApi.GetAllEconomicIndices: " + e.Message );
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
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseEconomicIndices**](ApiResponseEconomicIndices.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetAllSicIndices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSICIndices)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSICIndices.md)

[//]: # (OPERATION:GetAllSicIndices_v2)

[//]: # (ENDPOINT:/indices/sic)

[//]: # (DOCUMENT_LINK:IndexApi.md#getallsicindices)

<a name="getallsicindices"></a>
## **GetAllSicIndices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllSicIndices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSICIndices GetAllSicIndices (int? pageSize = null, string nextPage = null)

#### All SIC Indices


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
  public class GetAllSicIndicesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var indexApi = new IndexApi();
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseSICIndices result = indexApi.GetAllSicIndices(pageSize, nextPage);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling IndexApi.GetAllSicIndices: " + e.Message );
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
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSICIndices**](ApiResponseSICIndices.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetAllStockMarketIndices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStockMarketIndices)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStockMarketIndices.md)

[//]: # (OPERATION:GetAllStockMarketIndices_v2)

[//]: # (ENDPOINT:/indices/stock_market)

[//]: # (DOCUMENT_LINK:IndexApi.md#getallstockmarketindices)

<a name="getallstockmarketindices"></a>
## **GetAllStockMarketIndices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetAllStockMarketIndices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockMarketIndices GetAllStockMarketIndices (int? pageSize = null, string nextPage = null)

#### All Stock Market Indices


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
  public class GetAllStockMarketIndicesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var indexApi = new IndexApi();
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseStockMarketIndices result = indexApi.GetAllStockMarketIndices(pageSize, nextPage);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling IndexApi.GetAllStockMarketIndices: " + e.Message );
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
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockMarketIndices**](ApiResponseStockMarketIndices.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetEconomicIndexById)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.EconomicIndex)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:EconomicIndex.md)

[//]: # (OPERATION:GetEconomicIndexById_v2)

[//]: # (ENDPOINT:/indices/economic/{identifier})

[//]: # (DOCUMENT_LINK:IndexApi.md#geteconomicindexbyid)

<a name="geteconomicindexbyid"></a>
## **GetEconomicIndexById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetEconomicIndexById_v2)

[//]: # (START_OVERVIEW)

> EconomicIndex GetEconomicIndexById (string identifier)

#### Lookup Economic Index


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
  public class GetEconomicIndexByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var indexApi = new IndexApi();
      var identifier = "$GDP";  // string | An Index Identifier (symbol, Intrinio ID)

      try
      {
        EconomicIndex result = indexApi.GetEconomicIndexById(identifier);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling IndexApi.GetEconomicIndexById: " + e.Message );
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**EconomicIndex**](EconomicIndex.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetEconomicIndexDataPointNumber)

[//]: # (RETURN_TYPE:decimal?)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetEconomicIndexDataPointNumber_v2)

[//]: # (ENDPOINT:/indices/economic/{identifier}/data_point/{tag}/number)

[//]: # (DOCUMENT_LINK:IndexApi.md#geteconomicindexdatapointnumber)

<a name="geteconomicindexdatapointnumber"></a>
## **GetEconomicIndexDataPointNumber**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetEconomicIndexDataPointNumber_v2)

[//]: # (START_OVERVIEW)

> decimal? GetEconomicIndexDataPointNumber (string identifier, string tag)

#### Data Point (Number) for an Economic Index

Returns a numeric value for the given `tag` for the Economic Index with the given `identifier`

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
  public class GetEconomicIndexDataPointNumberExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var indexApi = new IndexApi();
      var identifier = "$GDP";  // string | An Index Identifier (symbol, Intrinio ID)
      var tag = "level";  // string | An Intrinio data tag <a href='https://data.intrinio.com/data-tags/economic'>reference</a>

      try
      {
        decimal? result = indexApi.GetEconomicIndexDataPointNumber(identifier, tag);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling IndexApi.GetEconomicIndexDataPointNumber: " + e.Message );
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;reference&lt;/a&gt; |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**decimal?**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetEconomicIndexDataPointText)

[//]: # (RETURN_TYPE:string)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetEconomicIndexDataPointText_v2)

[//]: # (ENDPOINT:/indices/economic/{identifier}/data_point/{tag}/text)

[//]: # (DOCUMENT_LINK:IndexApi.md#geteconomicindexdatapointtext)

<a name="geteconomicindexdatapointtext"></a>
## **GetEconomicIndexDataPointText**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetEconomicIndexDataPointText_v2)

[//]: # (START_OVERVIEW)

> string GetEconomicIndexDataPointText (string identifier, string tag)

#### Data Point (Text) for an Economic Index

Returns a text value for the given `tag` for the Economic Index with the given `identifier`

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
  public class GetEconomicIndexDataPointTextExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var indexApi = new IndexApi();
      var identifier = "$GDP";  // string | An Index Identifier (symbol, Intrinio ID)
      var tag = "level";  // string | An Intrinio data tag ID or code-name

      try
      {
        string result = indexApi.GetEconomicIndexDataPointText(identifier, tag);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling IndexApi.GetEconomicIndexDataPointText: " + e.Message );
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code-name |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**string**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetEconomicIndexHistoricalData)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseEconomicIndexHistoricalData)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseEconomicIndexHistoricalData.md)

[//]: # (OPERATION:GetEconomicIndexHistoricalData_v2)

[//]: # (ENDPOINT:/indices/economic/{identifier}/historical_data/{tag})

[//]: # (DOCUMENT_LINK:IndexApi.md#geteconomicindexhistoricaldata)

<a name="geteconomicindexhistoricaldata"></a>
## **GetEconomicIndexHistoricalData**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetEconomicIndexHistoricalData_v2)

[//]: # (START_OVERVIEW)

> ApiResponseEconomicIndexHistoricalData GetEconomicIndexHistoricalData (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)

#### Historical Data for an Economic Index

Returns historical values for the given `tag` and the Economic Index with the given `identifier`

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
  public class GetEconomicIndexHistoricalDataExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var indexApi = new IndexApi();
      var identifier = "$GDP";  // string | An Index Identifier (symbol, Intrinio ID)
      var tag = "level";  // string | An Intrinio data tag <a href='https://data.intrinio.com/data-tags/economic'>reference</a>
      var type = "";  // string | Filter by type, when applicable (optional) 
      var startDate = DateTime.Parse("2018-01-01");  // DateTime? | Get historical data on or after this date (optional) 
      var endDate = DateTime.Now;  // DateTime? | Get historical data on or before this date (optional) 
      var sortOrder = "desc";  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseEconomicIndexHistoricalData result = indexApi.GetEconomicIndexHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, pageSize, nextPage);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling IndexApi.GetEconomicIndexHistoricalData: " + e.Message );
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag &lt;a href&#x3D;&#39;https://data.intrinio.com/data-tags/economic&#39;&gt;reference&lt;/a&gt; |  &nbsp;
 **type** | string| Filter by type, when applicable | [optional]  &nbsp;
 **startDate** | DateTime?| Get historical data on or after this date | [optional]  &nbsp;
 **endDate** | DateTime?| Get historical data on or before this date | [optional]  &nbsp;
 **sortOrder** | string| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc] &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseEconomicIndexHistoricalData**](ApiResponseEconomicIndexHistoricalData.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetSicIndexById)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.SICIndex)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:SICIndex.md)

[//]: # (OPERATION:GetSicIndexById_v2)

[//]: # (ENDPOINT:/indices/sic/{identifier})

[//]: # (DOCUMENT_LINK:IndexApi.md#getsicindexbyid)

<a name="getsicindexbyid"></a>
## **GetSicIndexById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSicIndexById_v2)

[//]: # (START_OVERVIEW)

> SICIndex GetSicIndexById (string identifier)

#### Lookup SIC Index


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
  public class GetSicIndexByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var indexApi = new IndexApi();
      var identifier = "$SIC.1";  // string | An Index Identifier (symbol, Intrinio ID)

      try
      {
        SICIndex result = indexApi.GetSicIndexById(identifier);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling IndexApi.GetSicIndexById: " + e.Message );
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**SICIndex**](SICIndex.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetSicIndexDataPointNumber)

[//]: # (RETURN_TYPE:decimal?)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetSicIndexDataPointNumber_v2)

[//]: # (ENDPOINT:/indices/sic/{identifier}/data_point/{tag}/number)

[//]: # (DOCUMENT_LINK:IndexApi.md#getsicindexdatapointnumber)

<a name="getsicindexdatapointnumber"></a>
## **GetSicIndexDataPointNumber**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSicIndexDataPointNumber_v2)

[//]: # (START_OVERVIEW)

> decimal? GetSicIndexDataPointNumber (string identifier, string tag)

#### Data Point (Number) for an SIC Index

Returns a numeric value for the given `tag` for the SIC Index with the given `identifier`

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
  public class GetSicIndexDataPointNumberExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var indexApi = new IndexApi();
      var identifier = "$SIC.1";  // string | An Index Identifier (symbol, Intrinio ID)
      var tag = "level";  // string | An Intrinio data tag ID or code-name

      try
      {
        decimal? result = indexApi.GetSicIndexDataPointNumber(identifier, tag);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling IndexApi.GetSicIndexDataPointNumber: " + e.Message );
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code-name |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**decimal?**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetSicIndexDataPointText)

[//]: # (RETURN_TYPE:string)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetSicIndexDataPointText_v2)

[//]: # (ENDPOINT:/indices/sic/{identifier}/data_point/{tag}/text)

[//]: # (DOCUMENT_LINK:IndexApi.md#getsicindexdatapointtext)

<a name="getsicindexdatapointtext"></a>
## **GetSicIndexDataPointText**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSicIndexDataPointText_v2)

[//]: # (START_OVERVIEW)

> string GetSicIndexDataPointText (string identifier, string tag)

#### Data Point (Text) for an SIC Index

Returns a text value for the given `tag` for the SIC Index with the given `identifier`

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
  public class GetSicIndexDataPointTextExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var indexApi = new IndexApi();
      var identifier = "$SIC.1";  // string | An Index Identifier (symbol, Intrinio ID)
      var tag = "level";  // string | An Intrinio data tag ID or code-name

      try
      {
        string result = indexApi.GetSicIndexDataPointText(identifier, tag);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling IndexApi.GetSicIndexDataPointText: " + e.Message );
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code-name |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**string**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetSicIndexHistoricalData)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSICIndexHistoricalData)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSICIndexHistoricalData.md)

[//]: # (OPERATION:GetSicIndexHistoricalData_v2)

[//]: # (ENDPOINT:/indices/sic/{identifier}/historical_data/{tag})

[//]: # (DOCUMENT_LINK:IndexApi.md#getsicindexhistoricaldata)

<a name="getsicindexhistoricaldata"></a>
## **GetSicIndexHistoricalData**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetSicIndexHistoricalData_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSICIndexHistoricalData GetSicIndexHistoricalData (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)

#### Historical Data for an SIC Index

Returns historical values for the given `tag` and the SIC Index with the given `identifier`

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
  public class GetSicIndexHistoricalDataExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var indexApi = new IndexApi();
      var identifier = "$SIC.1";  // string | An Index Identifier (symbol, Intrinio ID)
      var tag = "marketcap";  // string | An Intrinio data tag ID or code-name
      var type = "";  // string | Filter by type, when applicable (optional) 
      var startDate = DateTime.Parse("2018-01-01");  // DateTime? | Get historical data on or after this date (optional) 
      var endDate = DateTime.Now;  // DateTime? | Get historical data on or before this date (optional) 
      var sortOrder = "desc";  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseSICIndexHistoricalData result = indexApi.GetSicIndexHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, pageSize, nextPage);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling IndexApi.GetSicIndexHistoricalData: " + e.Message );
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code-name |  &nbsp;
 **type** | string| Filter by type, when applicable | [optional]  &nbsp;
 **startDate** | DateTime?| Get historical data on or after this date | [optional]  &nbsp;
 **endDate** | DateTime?| Get historical data on or before this date | [optional]  &nbsp;
 **sortOrder** | string| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc] &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSICIndexHistoricalData**](ApiResponseSICIndexHistoricalData.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetStockMarketIndexById)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.StockMarketIndex)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:StockMarketIndex.md)

[//]: # (OPERATION:GetStockMarketIndexById_v2)

[//]: # (ENDPOINT:/indices/stock_market/{identifier})

[//]: # (DOCUMENT_LINK:IndexApi.md#getstockmarketindexbyid)

<a name="getstockmarketindexbyid"></a>
## **GetStockMarketIndexById**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockMarketIndexById_v2)

[//]: # (START_OVERVIEW)

> StockMarketIndex GetStockMarketIndexById (string identifier)

#### Lookup Stock Market Index


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
  public class GetStockMarketIndexByIdExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var indexApi = new IndexApi();
      var identifier = "$DJI";  // string | An Index Identifier (symbol, Intrinio ID)

      try
      {
        StockMarketIndex result = indexApi.GetStockMarketIndexById(identifier);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling IndexApi.GetStockMarketIndexById: " + e.Message );
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**StockMarketIndex**](StockMarketIndex.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetStockMarketIndexDataPointNumber)

[//]: # (RETURN_TYPE:decimal?)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetStockMarketIndexDataPointNumber_v2)

[//]: # (ENDPOINT:/indices/stock_market/{identifier}/data_point/{tag}/number)

[//]: # (DOCUMENT_LINK:IndexApi.md#getstockmarketindexdatapointnumber)

<a name="getstockmarketindexdatapointnumber"></a>
## **GetStockMarketIndexDataPointNumber**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockMarketIndexDataPointNumber_v2)

[//]: # (START_OVERVIEW)

> decimal? GetStockMarketIndexDataPointNumber (string identifier, string tag)

#### Data Point (Number) for Stock Market Index

Returns a numeric value for the given `tag` for the Stock Market Index with the given `identifier`

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
  public class GetStockMarketIndexDataPointNumberExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var indexApi = new IndexApi();
      var identifier = "$DJI";  // string | An Index Identifier (symbol, Intrinio ID)
      var tag = "level";  // string | An Intrinio data tag ID or code-name

      try
      {
        decimal? result = indexApi.GetStockMarketIndexDataPointNumber(identifier, tag);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling IndexApi.GetStockMarketIndexDataPointNumber: " + e.Message );
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code-name |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**decimal?**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetStockMarketIndexDataPointText)

[//]: # (RETURN_TYPE:string)

[//]: # (RETURN_TYPE_KIND:primitive)

[//]: # (RETURN_TYPE_DOC:)

[//]: # (OPERATION:GetStockMarketIndexDataPointText_v2)

[//]: # (ENDPOINT:/indices/stock_market/{identifier}/data_point/{tag}/text)

[//]: # (DOCUMENT_LINK:IndexApi.md#getstockmarketindexdatapointtext)

<a name="getstockmarketindexdatapointtext"></a>
## **GetStockMarketIndexDataPointText**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockMarketIndexDataPointText_v2)

[//]: # (START_OVERVIEW)

> string GetStockMarketIndexDataPointText (string identifier, string tag)

#### Data Point (Text) for Stock Market Index

Returns a text value for the given `tag` for the Stock Market Index with the given `identifier`

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
  public class GetStockMarketIndexDataPointTextExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var indexApi = new IndexApi();
      var identifier = "$DJI";  // string | An Index Identifier (symbol, Intrinio ID)
      var tag = "level";  // string | An Intrinio data tag ID or code-name

      try
      {
        string result = indexApi.GetStockMarketIndexDataPointText(identifier, tag);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling IndexApi.GetStockMarketIndexDataPointText: " + e.Message );
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code-name |  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

**string**

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:GetStockMarketIndexHistoricalData)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStockMarketIndexHistoricalData)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStockMarketIndexHistoricalData.md)

[//]: # (OPERATION:GetStockMarketIndexHistoricalData_v2)

[//]: # (ENDPOINT:/indices/stock_market/{identifier}/historical_data/{tag})

[//]: # (DOCUMENT_LINK:IndexApi.md#getstockmarketindexhistoricaldata)

<a name="getstockmarketindexhistoricaldata"></a>
## **GetStockMarketIndexHistoricalData**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/GetStockMarketIndexHistoricalData_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockMarketIndexHistoricalData GetStockMarketIndexHistoricalData (string identifier, string tag, string type = null, DateTime? startDate = null, DateTime? endDate = null, string sortOrder = null, int? pageSize = null, string nextPage = null)

#### Historical Data for Stock Market Index

Returns historical values for the given `tag` and the Stock Market Index with the given `identifier`

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
  public class GetStockMarketIndexHistoricalDataExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var indexApi = new IndexApi();
      var identifier = "$DJI";  // string | An Index Identifier (symbol, Intrinio ID)
      var tag = "level";  // string | An Intrinio data tag ID or code-name
      var type = "";  // string | Filter by type, when applicable (optional) 
      var startDate = DateTime.Parse("2018-01-01");  // DateTime? | Get historical data on or after this date (optional) 
      var endDate = DateTime.Now;  // DateTime? | Get historical data on or before this date (optional) 
      var sortOrder = "desc";  // string | Sort by date `asc` or `desc` (optional)  (default to desc)
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)
      var nextPage = "";  // string | Gets the next page of data from a previous API call (optional) 

      try
      {
        ApiResponseStockMarketIndexHistoricalData result = indexApi.GetStockMarketIndexHistoricalData(identifier, tag, type, startDate, endDate, sortOrder, pageSize, nextPage);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling IndexApi.GetStockMarketIndexHistoricalData: " + e.Message );
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
 **identifier** | string| An Index Identifier (symbol, Intrinio ID) |  &nbsp;
 **tag** | string| An Intrinio data tag ID or code-name |  &nbsp;
 **type** | string| Filter by type, when applicable | [optional]  &nbsp;
 **startDate** | DateTime?| Get historical data on or after this date | [optional]  &nbsp;
 **endDate** | DateTime?| Get historical data on or before this date | [optional]  &nbsp;
 **sortOrder** | string| Sort by date &#x60;asc&#x60; or &#x60;desc&#x60; | [optional] [default to desc] &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
 **nextPage** | string| Gets the next page of data from a previous API call | [optional]  &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockMarketIndexHistoricalData**](ApiResponseStockMarketIndexHistoricalData.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:SearchEconomicIndices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseEconomicIndicesSearch)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseEconomicIndicesSearch.md)

[//]: # (OPERATION:SearchEconomicIndices_v2)

[//]: # (ENDPOINT:/indices/economic/search)

[//]: # (DOCUMENT_LINK:IndexApi.md#searcheconomicindices)

<a name="searcheconomicindices"></a>
## **SearchEconomicIndices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/SearchEconomicIndices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseEconomicIndicesSearch SearchEconomicIndices (string query, int? pageSize = null)

#### Search Economic Indices

Searches for indices using the text in `query`

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
  public class SearchEconomicIndicesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var indexApi = new IndexApi();
      var query = "GDP";  // string | Search query
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)

      try
      {
        ApiResponseEconomicIndicesSearch result = indexApi.SearchEconomicIndices(query, pageSize);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling IndexApi.SearchEconomicIndices: " + e.Message );
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
 **query** | string| Search query |  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseEconomicIndicesSearch**](ApiResponseEconomicIndicesSearch.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:SearchSicIndices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseSICIndicesSearch)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseSICIndicesSearch.md)

[//]: # (OPERATION:SearchSicIndices_v2)

[//]: # (ENDPOINT:/indices/sic/search)

[//]: # (DOCUMENT_LINK:IndexApi.md#searchsicindices)

<a name="searchsicindices"></a>
## **SearchSicIndices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/SearchSicIndices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseSICIndicesSearch SearchSicIndices (string query, int? pageSize = null)

#### Search SIC Indices

Searches for indices using the text in `query`

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
  public class SearchSicIndicesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var indexApi = new IndexApi();
      var query = "agriculture";  // string | Search query
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)

      try
      {
        ApiResponseSICIndicesSearch result = indexApi.SearchSicIndices(query, pageSize);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling IndexApi.SearchSicIndices: " + e.Message );
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
 **query** | string| Search query |  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseSICIndicesSearch**](ApiResponseSICIndicesSearch.md)

[//]: # (END_OPERATION)


[//]: # (START_OPERATION)

[//]: # (CLASS:Intrinio.SDK.Api.IndexApi)

[//]: # (METHOD:SearchStockMarketsIndices)

[//]: # (RETURN_TYPE:Intrinio.SDK.Model.ApiResponseStockMarketIndicesSearch)

[//]: # (RETURN_TYPE_KIND:object)

[//]: # (RETURN_TYPE_DOC:ApiResponseStockMarketIndicesSearch.md)

[//]: # (OPERATION:SearchStockMarketsIndices_v2)

[//]: # (ENDPOINT:/indices/stock_market/search)

[//]: # (DOCUMENT_LINK:IndexApi.md#searchstockmarketsindices)

<a name="searchstockmarketsindices"></a>
## **SearchStockMarketsIndices**

[**View Intrinio API Documentation**](https://docs.intrinio.com/documentation/csharp/SearchStockMarketsIndices_v2)

[//]: # (START_OVERVIEW)

> ApiResponseStockMarketIndicesSearch SearchStockMarketsIndices (string query, int? pageSize = null)

#### Search Stock Market Indices

Searches for indices using the text in `query`

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
  public class SearchStockMarketsIndicesExample
  {
    public static void Main()
    {
      Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");

      var indexApi = new IndexApi();
      var query = "dow";  // string | Search query
      var pageSize = 100;  // int? | The number of results to return (optional)  (default to 100)

      try
      {
        ApiResponseStockMarketIndicesSearch result = indexApi.SearchStockMarketsIndices(query, pageSize);
        Console.WriteLine(result.ToJson());
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception when calling IndexApi.SearchStockMarketsIndices: " + e.Message );
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
 **query** | string| Search query |  &nbsp;
 **pageSize** | int?| The number of results to return | [optional] [default to 100] &nbsp;
<br/>

[//]: # (END_PARAMETERS)

### Return type

[**ApiResponseStockMarketIndicesSearch**](ApiResponseStockMarketIndicesSearch.md)

[//]: # (END_OPERATION)

