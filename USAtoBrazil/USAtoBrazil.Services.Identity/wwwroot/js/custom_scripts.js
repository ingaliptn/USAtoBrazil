(function($) {
	"use strict";
	
	//Hide Loading Box (Preloader)
	function handlePreloader() {
		if($('.preloader').length){
			$('.preloader').delay(200).fadeOut(500);
		}
	}
	
	//Update Header Style and Scroll to Top
	function headerStyle() {
		if($('.header_section').length){
			var windowpos = $(window).scrollTop();
			var siteHeader = $('.header_section');
			var scrollLink = $('.scroll-to-top');
			var sticky_header = $('.header_section .sticky-header, .header_section .mobile-sticky-header');
			if (windowpos > 500) {
				siteHeader.addClass('fixed-header');
				sticky_header.addClass('fixed-header animated slideInDown');
				scrollLink.fadeIn(300);
			} else{
				siteHeader.removeClass('fixed-header');
				sticky_header.removeClass('fixed-header animated slideInDown');
				scrollLink.fadeOut(300);
			}
		}
	}
	headerStyle();


	// Mega Menu Offset
	function Mega_Menu(){
		if($('.mega-menu').length){
			var menu_width = $('.mega-menu').attr("data-width");
			$('.mega-menu').width(menu_width);
		}
	}
	Mega_Menu();


	//Mobile Nav Hide Show
	if($('.mobile-menu').length){
		var mobileMenuContent = $('.header_section .nav-outer .navigation_combo').html();
		var mobileHeaderContent = $('.header_section .nav-outer .outer-box').html();
		var stickyMenuContent = $('.header_section .header_wrap').html();
		$('.mobileNavCombo_header .nav-outer,.mobile-sticky-header .nav-outer').append('<div class="mobile-nav-toggler"><span class="icon fa fa-bars"></span></div>');
		$('.mobile-menu .nav_combo_block').append(mobileMenuContent);
		$('.mobileNavCombo_header .nav-outer').append(mobileHeaderContent);
		$('.sticky-header .header_wrap').append(stickyMenuContent);
		$('.sticky-header .navbar-collapse').addClass('show');
		$('.mobile-menu .nav_combo_block .navbar-collapse').addClass('show');
		$('.mobile-menu .close-btn, .mobile-menu-back-drop').on('click', function() {
			$('body').removeClass('mobile-menu-visible');
		});

		//Submenu Dropdown Toggle
		if($('.header_section li.dropdown ul').length){
			$('.header_section .nav_multilabel li.dropdown').append('<div class="dropdown-btn"><span class="flaticon-arrow-right"></span></div>');
		}

		//Dropdown Button
		$('.mobile-menu li.dropdown .dropdown-btn').on('click', function() {
			$(this).prev('ul').slideToggle(500);
			$(this).toggleClass('active');
			$(this).parent('li').toggleClass('active');

		});

		//Megamenu Toggle
		$('.mobile-menu li.dropdown .dropdown-btn').on('click', function() {
			$(this).prev('.mega-menu').slideToggle(500);
		});


		//Dropdown toggle
		$(".navigation_combo .nav_multilabel li.dropdown").not( "li.has-mega-menu" ).on('mouseenter', function(){
		    $(this).children('ul').stop().slideDown(300);
		 });
		$(".navigation_combo .nav_multilabel li.dropdown").not( "li.has-mega-menu" ).on('mouseleave', function(){
		    $(this).children('ul').stop().slideUp(300);
		});

		//Mega Menu toggle
		$(".navigation_combo .nav_multilabel > li.has-mega-menu").on('mouseenter', function(){
		    $(this).children('.mega-menu').stop().slideDown(300);

		});
		$(".navigation_combo .nav_multilabel > li.has-mega-menu").on('mouseleave', function(){
		    $(this).children('.mega-menu').stop().slideUp(300);
		});

		//Menu Toggle Btn
		$('.mobile-nav-toggler').on('click', function() {
			$('body').addClass('mobile-menu-visible');
		});

		//Menu Toggle Btn
		$('.mobile-menu .menu-backdrop,.mobile-menu .close-btn').on('click', function() {
			$('body').removeClass('mobile-menu-visible');
		});

		//Sidebar Cart
		$('.header_section .cart-btn').on('click', function() {
			$('body').addClass('sidebar-cart-active');
		});
		//Menu Toggle Btn
		$('.header_section .cart-back-drop, .header_section .close-cart').on('click', function() {
			$('body').removeClass('sidebar-cart-active');
		});
		
		
		//Sidebar Company Overview
		$('.header_section .companyInfo-btn').on('click', function() {
			$('body').addClass('sidebar-companyInfo-active');
		});
		//Menu Toggle Btn
		$('.header_section .companyInfo-back-drop, .header_section .close-companyInfo').on('click', function() {
			$('body').removeClass('sidebar-companyInfo-active');
		});
	}	

	//Header Search
	if($('.search-btn').length) {
		$('.search-btn').on('click', function() {
			$('body').addClass('search-active');
		});
		$('.close-search, .search-back-drop').on('click', function() {
			$('body').removeClass('search-active');
		});
	}
	
	//Make Content Sticky
	if ($('.sticky-sidebar').length) {
	    $('.sidebar-side').theiaStickySidebar({
	      // Settings
	      additionalMarginTop: 100
	    });
	}

    $(".portfolio-block,.portfolio-block-three, .portfolio-block-four").each(function(i, elem) {
        var url = $(this).find('img').attr("src");
        var Image_box = $(this).find('.image-box').css({
            "backgroundImage": "url(" + url + ")",
        });
    });

    //Sidebar Cart
	$('.main-header .cart-btn').on('click', function() {
		$('body').addClass('sidebar-cart-active');
	});
	
	//Sidebar Cart
	$('.main-header .companyInfo-btn').on('click', function() {
		$('body').addClass('sidebar-companyInfo-active');
	});


/* These help to header sticky reload */
/* ==========================================================================
   When document is Resize, do
   ========================================================================== */
   	$(window).on('resize', function() {
		Mega_Menu();
	});

/* ==========================================================================
   When document is Scrollig, do
   ========================================================================== */
	
	$(window).on('scroll', function() {
		headerStyle();
	});
	
	/* ==========================================================================
   When document is loading, do
   ========================================================================== 
	
	$(window).on('load', function() {
		handlePreloader();
		defaultMasonry();
	});*/
	
	//Owl Carousel Scripts styles
	$('.OwlCarouselDemoBox').owlCarousel({
		loop:true,
		//items: 1,
		margin:10,
		autoplay: false,
		autoHeight: false,
		animateOut: 'fadeOut',
		animateIn: 'fadeIn',
		autoplayHoverPause: false,
		autoplayTimeout:5000,
		//smartSpeed: 1200,
		mouseDrag : true,
		touchDrag : true,
		nav:true,
		navText: ['<i class="fa fa-chevron-left"></i>', '<i class="fa fa-chevron-right"></i>'],
		dots: true,
		responsive:{
			0:{
				items:1
			},
			600:{
				items:2
			},
			1000:{
				items:3
			},
			1100:{
				items:4
			},
			1200:{
				items:5
			}
		}
	});
	
	//Home Slide option one
	/*
	$('.OwlHomeSlider').owlCarousel({
		loop:true,
		margin:10,
		autoplay: false,
		autoHeight: false,
		animateOut: 'fadeOut',
		animateIn: 'fadeIn',
		autoplayHoverPause: false,
		autoplayTimeout:5000,
		smartSpeed: 1200,
		mouseDrag : true,
		touchDrag : true,
		nav:true,
		navText: ['<i class="fa fa-arrow-circle-o-left"></i>', '<i class="fa fa-arrow-circle-o-right"></i>'],
		dots: false,
		items:1
	}); */
	
	
	//Slick Slider Carousel Scritps
	// data - background
	/*
	$("[data-background]").each(function () {
		$(this).css("background-image", "url(" + $(this).attr("data-background") + ")")
	})
	*/

      $(".searchBox_BTN").click(function(){
        $(".searchBox_wrapper").addClass("active");
        $(this).css("display", "none");
        $(".searchBox_data").fadeIn(500);
        $(".search_closeBtn").fadeIn(500);
        $(".searchBox_data .searchBottom_line").addClass("active");
        setTimeout(function(){
          $("input").focus();
          $(".searchBox_data label").fadeIn(500);
          $(".searchBox_data span").fadeIn(500);
        }, 800);
      });
      $(".search_closeBtn").click(function(){
        $(".searchBox_wrapper").removeClass("active");
        $(".searchBox_BTN").fadeIn(800);
        $(".searchBox_data").fadeOut(500);
        $(".search_closeBtn").fadeOut(500);
        $(".searchBox_data .searchBottom_line").removeClass("active");
        $("input").val("");
        $(".searchBox_data label").fadeOut(500);
        $(".searchBox_data span").fadeOut(500);
      });
	  
	  
$(document).ready(function(){
    // Add Active Class
    $(".searchExpFull_Icon").click(function(){
        $(".searchExpFull_screen").addClass("active");
    });

    // Remove Active Class
    $(".searchExpFull_CloseIcon").click(function(){
        $(".searchExpFull_screen").removeClass("active");
    });
});



})(window.jQuery);

//Video Pop up own site
$(function () {
   $('#videoPopUpBox').VideoPopUp({
		backgroundColor: "#000000",
		opener: "siteVideoPOp",
		maxweight: "340",
		idvideo: "videoPopCanvus"
	});
});


//Video Play Control Options
var fullSVideo = document.getElementById("fullScreenVideo");
var videoBtn = document.getElementById("videoControlBtn");

function bannerFullVideo() {
  if (fullSVideo.paused) {
    fullSVideo.play();
    videoBtn.innerHTML = "Pause";
  } else {
    fullSVideo.pause();
    videoBtn.innerHTML = "Play";
  }
}
new WOW().init();

//VIDEO POP JS
(function ($) {

    $.fn.VideoPopUp = function (options) {
        
        var defaults = {
            backgroundColor: "#000000",
            opener: "video",
            maxweight: "640",
            pausevideo: false,
            idvideo: ""
        };
        
        var patter = this.attr('id');

        var settings = $.extend({}, defaults, options);

        var video = document.getElementById(settings.idvideo);
        function stopVideo() {
            var tag = $('#' + patter + '').get(0).tagName;
            if (tag == 'video') {
                video.pause();
                video.currentTime = 0;
            }
        }
        
        $('#' + patter + '').css("display", "none");
        $('#' + patter + '').append('<div id="opct"></div>');
        $('#opct').css("background", settings.backgroundColor);
        $('#' + patter + '').css("z-index", "100001");
        $('#' + patter + '').css("position", "fixed")
        $('#' + patter + '').css("top", "0");
        $('#' + patter + '').css("bottom", "0");
        $('#' + patter + '').css("right", "0");
        $('#' + patter + '').css("left", "0");
        $('#' + patter + '').css("padding", "auto");
        $('#' + patter + '').css("text-align", "center");
        $('#' + patter + '').css("background", "none");
        $('#' + patter + '').css("vertical-align", "vertical-align");
        $("#videoPopContent").css("z-index", "100002");
        $('#' + patter + '').append('<div id="closer_videopopup">&times;</div>');
        $("#" + settings.opener + "").on('click', function () {
            $('#' + patter + "").show();
            $('#'+settings.idvideo+'').trigger('play');

        });
        $("#closer_videopopup").on('click', function () {
            if(settings.pausevideo==true){
                    $('#'+settings.idvideo+'').trigger('pause');
                }else{
                    stopVideo();
                }
            $('#' + patter + "").hide();
        });
        return this.css({

        });
    };

}(jQuery));
