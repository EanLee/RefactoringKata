# RefactorKata

存在一份處理 Bookmark 文字檔的 console 程式，但現行功能已經無法滿足使用者，需要在保持原本功能正常的前提下，不停的增加/修改功能。

## 現有功能如下

- 待處理的檔案的內容為 `url | web site title` 的資料行組成。
- 移除重覆相同的 Url bookmark
- 移除 utm, fblid 的 tracking code
- 處理結果，會儲存於 csv 檔

## 已知後續的需求變更順序如下

- 在執行 console 程式時，可傳入指定的檔案位置，若無傳入參數，則維持讀取原本的檔案位置。
- 將處理後的資料改存至資料庫。
- 增加移除 Url 中，特定 tracking code 的功能。
- 將 console 程式改為 webapi 的方式，提供外部使用。
- 新增的資料，若在現存資料已存在相同 url，不進行增加。

請試著補上測試與重構。

## 需求變更的分析與延伸思考

- 在執行 console 程式時，可傳入指定的檔案位置，若無傳入參數，則維持讀取原本的檔案位置。
  - 延伸思考: 
    - 在完全沒有測試的情況下，要如何進行功能調整。
    - 業務邏輯與應用程式是否需要分層？有何意義？
- 將處理後的資料改存至資料庫。
  - 延伸思考: 
    - 如何收斂儲存資料的邏輯
    - 測試保護的重點
- 增加移除 Url 中，特定 tracking code 的功能。
- 將 console 程式改為 webapi 的方式，提供外部使用。
- 新增的資料，若在現存資料已存在相同 url，不進行增加。

## 測試可能會使用到的方法

```c#
public string GetFileHash(string filename)
{
    var hash = new SHA1Managed();
    var clearBytes = File.ReadAllBytes(filename);
    var hashedBytes = hash.ComputeHash(clearBytes);
    return ConvertBytesToHex(hashedBytes);
}

public string ConvertBytesToHex(byte[] bytes)
{
    var sb = new StringBuilder();
    for (var i = 0; i < bytes.Length; i++)
    {
        sb.Append(bytes[i].ToString("x"));
    }
    return sb.ToString();
}
```

