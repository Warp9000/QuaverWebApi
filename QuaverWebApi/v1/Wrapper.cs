using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QuaverWebApi;

public class Wrapper
{
    public readonly Endpoints Endpoints;

    private readonly HttpClient client;
    private readonly string baseUrl;

    public Wrapper()
    {
        Endpoints = new Endpoints(this);
        client = new HttpClient();
        baseUrl = "https://api.quavergame.com/v1/";
    }

    public Wrapper(HttpClient client, string baseUrl)
    {
        Endpoints = new Endpoints(this);
        this.client = client;
        this.baseUrl = baseUrl;
    }

    public async Task<string> GetAsync(string endpoint)
    {
        var url = baseUrl + endpoint.TrimStart('/');
        Debug.WriteLine("GET " + url);
        var response = await client.GetAsync(url);
        return await response.Content.ReadAsStringAsync();
    }

    public async Task<string> GetAsync(string endpoint, (string key, string value)[] queryParameters)
    {
        if (queryParameters.Length > 0)
        {
            endpoint += "?";
            foreach (var (key, value) in queryParameters)
            {
                endpoint += $"{key}={value}&";
            }

            endpoint = endpoint.TrimEnd('&');
        }

        return await GetAsync(endpoint);
    }

    public async Task<string> GetAsync(string endpoint, Dictionary<string, string> queryParameters)
    {
        if (queryParameters.Count > 0)
        {
            endpoint += "?";
            foreach (var (key, value) in queryParameters)
            {
                endpoint += $"{key}={value}&";
            }
        }

        return await GetAsync(endpoint);
    }

    public async Task<T> GetAsync<T>(string endpoint)
    {
        var str = await GetAsync(endpoint);
        return JsonConvert.DeserializeObject<T>(str) ?? throw new NullReferenceException();
    }

    public async Task<T> GetAsync<T>(string endpoint, (string key, string value)[] queryParameters)
    {
        var str = await GetAsync(endpoint, queryParameters);
        return JsonConvert.DeserializeObject<T>(str) ?? throw new NullReferenceException();
    }

    public async Task<T> GetAsync<T>(string endpoint, Dictionary<string, string> queryParameters)
    {
        var str = await GetAsync(endpoint, queryParameters);
        return JsonConvert.DeserializeObject<T>(str) ?? throw new NullReferenceException();
    }

    public async Task<T> GetAsync<T>(string endpoint, string subType)
    {
        var str = await GetAsync(endpoint);
        var obj = JsonConvert.DeserializeObject<Dictionary<string, object>>(str);
        if (obj == null)
        {
            throw new NullReferenceException();
        }

        if (obj["status"] == null)
        {
            throw new NullReferenceException();
        }

        if (obj[subType] == null)
        {
            throw new NullReferenceException();
        }

        if ((Int64)obj["status"] != 200)
        {
            throw new Exception($"Status code {(int)obj["status"]}");
        }

        var subTypeObj = JsonConvert.DeserializeObject<T>(obj[subType].ToString()!);
        if (subTypeObj == null)
        {
            throw new NullReferenceException();
        }

        return subTypeObj;
    }

    public async Task<T> GetAsync<T>(string endpoint, string subType, (string key, string value)[] queryParameters)
    {
        var str = await GetAsync(endpoint, queryParameters);
        var obj = JsonConvert.DeserializeObject<Dictionary<string, object>>(str);
        if (obj == null)
        {
            throw new NullReferenceException();
        }

        if (obj["status"] == null)
        {
            throw new NullReferenceException();
        }

        if (obj[subType] == null)
        {
            throw new NullReferenceException();
        }

        if ((Int64)obj["status"] != 200)
        {
            throw new Exception($"Status code {(int)obj["status"]}");
        }

        var subTypeObj = JsonConvert.DeserializeObject<T>(obj[subType].ToString()!);
        if (subTypeObj == null)
        {
            throw new NullReferenceException();
        }

        return subTypeObj;
    }

    public async Task<T> GetAsync<T>(string endpoint, string subType, Dictionary<string, string> queryParameters)
    {
        var str = await GetAsync(endpoint, queryParameters);
        var obj = JsonConvert.DeserializeObject<Dictionary<string, object>>(str);
        if (obj == null)
        {
            throw new NullReferenceException();
        }

        if (obj["status"] == null)
        {
            throw new NullReferenceException();
        }

        if (obj[subType] == null)
        {
            throw new NullReferenceException();
        }

        if ((Int64)obj["status"] != 200)
        {
            throw new Exception($"Status code {(int)obj["status"]}");
        }

        var subTypeObj = JsonConvert.DeserializeObject<T>(obj[subType].ToString()!);
        if (subTypeObj == null)
        {
            throw new NullReferenceException();
        }

        return subTypeObj;
    }
}
