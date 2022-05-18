$(function(){
    $("#form-total").steps({
        headerTag: "h2",
        bodyTag: "section",
        transitionEffect: "fade",
        enableAllSteps: true,
        autoFocus: true,
        transitionEffectSpeed: 500,
        titleTemplate : '<div class="title">#title#</div>',
        labels: {
            previous : 'Back',
            next : '<i class="zmdi zmdi-chevron-right"></i>',
            finish : '<i class="zmdi zmdi-chevron-right"></i>',
            current : ''
        },
        onStepChanging: function (event, currentIndex, newIndex) {
            
            var fullname = $('.firstname').val() + ' ' + $('.lastname').val();
            var email = $('.email').val();
            var phone = $('.phno').val();
            var address = $('.address').val();
            var gender = $('form input[type=radio]:checked').val();
            var zipcode = $('.zipcode').val();
            var dob = $('.dob').val();
            var designation = $('.designation').val();
            var department = $('.department').val();
            var location = $('.location').val()
            var manager = $('.manager').val();
            var doj = $('.doj').val();
            var prevemp = $('.prevemp').val();

            $('#fullname-val').text(fullname);
            $('#email-val').text(email);
            $('#phone-val').text(phone);
            $('#address-val').text(address);
            $('#gender-val').text(gender);
            $('#code-val').text(zipcode);
            $('#dob-val').text(dob);
            $('#designation-val').text(designation);
            $('#department-val').text(department);
            $('#loc-val').text(location);
            $('#manager-val').text(manager);
            $('#doj-val').text(doj);
            $('#prevemp-val').text(prevemp);
            
            return true;
        }
    });
});
