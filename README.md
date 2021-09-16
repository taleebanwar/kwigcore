# KWIG

!!! .NET core port of KWIG (https://github.com/yahch/kwig)

KIWG is a WYSIWYG editor for WinForm based on summernote.

[![Board Status](https://dev.azure.com/taleebanwar/f4599992-56fc-4f4e-81bc-f7f97700a339/2be72cf2-c872-4a04-acba-b1d77b9d6242/_apis/work/boardbadge/2ede280d-cf07-42f1-bc18-bd4a3637ae34?columnOptions=1)](https://dev.azure.com/taleebanwar/f4599992-56fc-4f4e-81bc-f7f97700a339/_boards/board/t/2be72cf2-c872-4a04-acba-b1d77b9d6242/Microsoft.RequirementCategory/)

![](https://raw.githubusercontent.com/yahch/kwig/master/screenshots/screenshot-1.png)

**Instructions:**

1. Use nuget to download package: ``` Install-Package KSharpEditor ```

2. Add KEditor control to your form

3. Buid & Run

**Events:**

```
// open file button event
Void OnOpenButtonClicked();
// save button event
Void OnSaveButtonClicked();
// Insert picture button event
Void OnInsertImageClicked();
// Editor loads success event
Void OnEditorLoadComplete();
// editor error event
Void OnEditorErrorOccured(Exception ex);
```

**Attributes:**

```
// editor version, same as summernote version number
KEditor.Version
// Set or get the editor Html content
KEditor.Html
```

**Methods:**

```
// editor clear reset
KEditor.Reset();
// insert html code
KEditor.InsertNode(string html)
// insert text
KEditor.InsertText(string text)
```
