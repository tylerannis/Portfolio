$(document).ready(function () {

    $('.carNext li').on('click', function () {
       
        //get the active slide
        

        var nextID = $(this).data('nextid');

        var activeSlide = $('.' + nextID +'.active');
        //get the next slide
        var nextSlide = activeSlide.next();

        var prevSlide = activeSlide.prev();
        //make sure it goes round and round and doesn't stop at the last image
        if (!nextSlide.hasClass(nextID)) {
            nextSlide = prevSlide.prev();
            

        }


        //remove the active class and add the hide class
        activeSlide.removeClass('active').addClass('hide');
        //remove the hide and make it active
        nextSlide.removeClass('hide').addClass('active');
    });


    //Turn the contact form to AJAX
    $('#contactForm').on('submit', function (event) {
        event.preventDefault();
        if ($(this).valid()) {
            $.post($(this).attr('action'), $(this).serialize(), function (data) {
                $('#container').html(data);
            });
        }


    });

});