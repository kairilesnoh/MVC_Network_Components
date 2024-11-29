$(document).ready(function () {
    $('#tableSelector').select2({
        placeholder: "View related tables",
        allowClear: true
    });

    $('#tableSelector').on('change', function () {
        // Hide all tables
        $('.tableDiv').hide();

        // Show the selected tables
        $(this).find('option:selected').each(function () {
            $('#' + $(this).val()).show();
        });
    });
});