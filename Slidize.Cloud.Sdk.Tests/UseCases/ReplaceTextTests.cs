//Copyright (c) 2024 Smallize Pty Ltd. All Rights Reserved
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Slidize.Cloud.Sdk.Api;
using Slidize.Cloud.Sdk.Model;

namespace Slidize.Cloud.Sdk.Tests.UseCases;

[TestClass]
public class ReplaceTextTests
{
    [TestMethod]
    public void ReplaceText()
    {
        var api = new SlidizeApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var replaceTextOptions = new ReplaceTextOptions()
        {
            IgnoreCase = true,
            NewValue = c_newValue,
            OldValue = c_oldValue
        };
        var stream = api.ReplaceText(new List<Stream>(){fileStream}, replaceTextOptions);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public void ReplaceTextWithHttpInfo()
    {
        var api = new SlidizeApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var replaceTextOptions = new ReplaceTextOptions()
        {
            IgnoreCase = true,
            NewValue = c_newValue,
            OldValue = c_oldValue
        };
        var apiResponse = api.ReplaceTextWithHttpInfo(new List<Stream>(){fileStream}, replaceTextOptions);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    [TestMethod]
    public async Task ReplaceTextAsync()
    {
        var api = new SlidizeApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var replaceTextOptions = new ReplaceTextOptions()
        {
            IgnoreCase = true,
            NewValue = c_newValue,
            OldValue = c_oldValue
        };
        var stream = await api.ReplaceTextAsync(new List<Stream>(){fileStream}, replaceTextOptions);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public async Task ReplaceTextWithHttpInfoAsync()
    {
        var api = new SlidizeApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var replaceTextOptions = new ReplaceTextOptions()
        {
            IgnoreCase = true,
            NewValue = c_newValue,
            OldValue = c_oldValue
        };
        var apiResponse = await api.ReplaceTextWithHttpInfoAsync(new List<Stream>(){fileStream}, replaceTextOptions);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }

    private const string c_testFile = "../../../../TestData/test.pptx";
    private const string c_oldValue = "Text to replace";
    private const string c_newValue = "New value";
}