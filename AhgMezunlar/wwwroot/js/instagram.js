function insta() {
    var instafeed = new Instafeed({
        get: 'user',
        clientId: ' c759912015d4433485dd6188bf0794fc',
        userId: '7293483568',
        accessToken: '7293483568.1677ed0.9a82d088c8c54e26813054b316528cc6',
        template: "<img class='rounded m-1' src='{{image}}' data-link='{{link}}' alt='{{caption}}'/>",
        resolution: 'thumbnail',
        limit: 100
    });
    instafeed.run();
};