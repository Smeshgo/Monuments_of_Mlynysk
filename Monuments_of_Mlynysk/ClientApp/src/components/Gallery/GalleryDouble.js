import React from 'react';
import {Box, Container, Grid} from "@material-ui/core";
import SimpleReactLightbox, {SRLWrapper} from "simple-react-lightbox";
import {makeStyles} from "@material-ui/core/styles";
import LazyLoad from "react-lazy-load";

const useStyles = makeStyles((theme) => ({
    image: {
        position: 'relative',
        boxShadow: 'rgba(0, 0, 0, 0.24) 0px 3px 8px',
    },
    imageText: {
        position: 'absolute',
        left: '0',
        bottom: '0',
        color: 'white',
        backgroundColor: 'black',
        padding: '3px',
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'center'
    }
}));

const options = {
    thumbnails: {
        showThumbnails: true,
    },
    settings: {
        disablePanzoom: true,
        disableWheelControls: true,
    }
};
const allImages = [];
const reqFull = require.context('./../../assets/images/Img/Dual/full', true, /\.jpg$/);
const reqMini = require.context('./../../assets/images/Img/Dual/Mini', true, /\.jpg$/);
const fullImagesList = [];
const fullImages = reqFull
    .keys()
    .map(path => fullImagesList.push({fullFile: reqFull(path)}))
const miniImagesList = [];
const miniImages = reqMini
    .keys()
    .map(path => miniImagesList.push({miniFile: reqMini(path)}))

const GalleryDouble = () => {
    const classes = useStyles();

    for (let i = 0; i < miniImagesList.length; i++) {
        allImages.push({path1: fullImagesList[i], path2: miniImagesList[i]});
    }

    return (
        <Container>
            <SimpleReactLightbox>
                <SRLWrapper options={options}>
                    <div className="content">
                        <Grid justify="flex-start"
                              alignItems="flex-start" container spacing={5}>

                            {allImages.length != 0 ? allImages.map((img, i) => (
                                    <Grid item
                                          xs={12} sm={6} md={4} lg={3}
                                          className={'col-image-half'}>
                                        <Box display={'flex'} justifyContent="center">

                                            <Box className={classes.image}>
                                                <LazyLoad onContentVisible={() => console.log('look ma I have been lazyloaded!')}>
                                                <a href={img.path1.fullFile.default}>
                                                    <img src={img.path2.miniFile.default} alt={`#${i+1}`}/>
                                                    <div className={classes.imageText}>#{i + 1}</div>
                                                </a>
                                                </LazyLoad>
                                            </Box>
                                        </Box>

                                    </Grid>
                                ))
                                : 'loading'}
                        </Grid>

                    </div>
                </SRLWrapper>
            </SimpleReactLightbox>
        </Container>
    );
}

export default GalleryDouble;
