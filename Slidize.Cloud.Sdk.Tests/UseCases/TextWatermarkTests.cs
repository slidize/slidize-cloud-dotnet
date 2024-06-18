//Copyright (c) 2024 Smallize Pty Ltd. All Rights Reserved
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Slidize.Cloud.Sdk.Api;
using Slidize.Cloud.Sdk.Model;

namespace Slidize.Cloud.Sdk.Tests.UseCases;

[TestClass]
public class TextWatermarkTests
{
    [TestMethod]
    public void TextWatermark()
    {
        var api = new SlidizeApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var watermarkOptions = new TextWatermarkOptions
        {
            Text = c_watermarkText,
            Color = c_watermarkColor,
            FontName = c_fontName,
            FontSize = c_fontSize,
            Angle = c_fontAngle
        };
        var stream = api.TextWatermark(new List<Stream>(){fileStream}, watermarkOptions);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public void TextWatermarkWithHttpInfo()
    {
        var api = new SlidizeApi();
        using var fileStream = File.Open(c_testFile, FileMode.Open);
        var watermarkOptions = new TextWatermarkOptions()
        {
            Text = c_watermarkText,
            Color = c_watermarkColor,
            FontName = c_fontName,
            FontSize = c_fontSize,
            Angle = c_fontAngle
        };
        var apiResponse = api.TextWatermarkWithHttpInfo(new List<Stream>(){fileStream}, watermarkOptions);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }
    
    [TestMethod]
    public async Task TextWatermarkOptions()
    {
        var api = new SlidizeApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var watermarkOptions = new TextWatermarkOptions()
        {
            Text = c_watermarkText,
            Color = c_watermarkColor,
            FontName = c_fontName,
            FontSize = c_fontSize,
            Angle = c_fontAngle
        };
        var stream = await api.TextWatermarkAsync(new List<Stream>(){fileStream}, watermarkOptions);
        Assert.IsTrue(stream.Length > 0);
    }
    
    [TestMethod]
    public async Task TextWatermarkWithHttpInfoAsync()
    {
        var api = new SlidizeApi();
        await using var fileStream = File.Open(c_testFile, FileMode.Open);
        var watermarkOptions = new TextWatermarkOptions()
        {
            Text = c_watermarkText,
            Color = c_watermarkColor,
            FontName = c_fontName,
            FontSize = c_fontSize,
            Angle = c_fontAngle
        };
        var apiResponse = await api.TextWatermarkWithHttpInfoAsync(new List<Stream>(){fileStream}, watermarkOptions);
        Assert.AreEqual(apiResponse.StatusCode, HttpStatusCode.OK);
        Assert.AreEqual(apiResponse.ResponseType, typeof(Stream));
    }

    private const string c_testFile = "../../../../TestData/test.pptx";
    private const string c_watermarkText = "Watermark text";
    private const string c_watermarkColor = "#FF0000";
    private const string c_fontName = "Arial";
    private const int c_fontSize = 32;
    private const int c_fontAngle = -45;
}