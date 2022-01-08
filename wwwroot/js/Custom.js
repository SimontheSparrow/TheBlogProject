

let index = 0;

function AddTag() {
    var tagEntry = document.getElementById("TagEntry");

    let searchResult = Search(tagEntry.value);
    if (searchResult != null) {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Duplicate tags are not allowed!'
            //footer: '<a href="">Why do I have this issue?</a>'
        })

    } else {
        let newOption = new Option(tagEntry.value, tagEntry.value);
        document.getElementById("TagList").options[index++] = newOption;
    }


    tagEntry.value = "";
    return true;
}

function DeleteTag() {

    let tagCount = 1;
    let tagList = document.getElementById("TagList");
    if (!tagList) {
        return false;
    }
    if (tagList.selectedIndex == -1) {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Choose a tag!'
        });
       // return true;
        while (tagCount > 0) {
            if (tagList.selectedIndex >= 0) {
                tagList.options[tagList.selectedIndex] = null;
            --tagCount;
        }
        else {
            tagCount = 0;
            index--;
        }
    }
}

$("form").on("submit", function () {

    $("#TagList option").prop("selected", "selected");
})

if (tagValues != '') {
    let tagArray = tagValues.split(",");
    for (let loop = 0; loop < tagArray.length; loop++) {
        ReplaceTag(tagArray[loop], loop);
        index++;
    }
}

function ReplaceTag(tag, index) {
    let newOption = new Option(tag, tag);
    document.getElementById("TagList").options[index] = newOption;
}

function Search(str) {
    if (str == "") {
        return 'Empty tags are not permitted';
    }
    var tagsEl = document.getElementById('TagList');
    if (tagsEl) {
        let options = tagsEl.options;
        for (let index = 0; index < options.length; index++) {
            if (options[index].value == str) {
                return 'Duplicate tags are not permitted';
            }
        }
    }
}