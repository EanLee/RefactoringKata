# RefactorKata

目前已經存在一份處理 Bookmark 文字檔的 console 程式。

現有功能如下
- 移除重覆相同的 Url bookmark
- 移除 utm, fblid 的 tracking code
- 處理結果，會儲存於 csv 檔

已知後續的需求變更順序如下
- 可外部指定處理的 txt 檔位置與名稱…
- 將處理後的資料改存至資料庫。
- 增加移除 Url 中，特定 tracking code 的功能。
- 將 console 程式改為 webapi 的方式，提供外部使用。
- 新增的資料，若在現存資料已存在相同 url，不進行增加。

請試著補上測試與重構。
