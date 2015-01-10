
/*global $:false */
/*global window: false */

(function(){
  "use strict";


$(function ($) {


    $(window).load(function(){
    

        
        var $container = $('.works-container');


        $container.isotope({
          // options
          itemSelector: '.works-item',
          layoutMode: 'masonry',
            filter: '.bentwood'
        });


        $('.works-filter li a').click(function(){
        $('.works-filter li a').removeClass('active');
        $(this).addClass('active');

        var selector = $(this).attr('data-filter');
              $('.works-container').isotope({ filter: selector });
              return false;
        });

        // window resize and layout regenerate
        $(window).resize(function() {
             $container.isotope({
              // options
              itemSelector: '.works-item',
              layoutMode: 'masonry',
            });

        });

        var isotopeInstance = $('.works-item').data('isotope');
        isotopeInstance.$allAtoms = isotopeInstance.$allAtoms.not(
        $content);
        $content.remove();

    });

      
        
   
});
// $(function ($)  : ends

})();
//  JSHint wrapper $(function ($)  : ends







  

