import Drawer from '@mui/material/Drawer';
import Hidden from '@mui/material/Hidden';
import SwipeableDrawer from '@mui/material/SwipeableDrawer';
import clsx from 'clsx';
import { forwardRef, ReactNode, useCallback, useEffect, useImperativeHandle, useState } from 'react';
import FusePageCardedSidebarContent from './FusePageCardedSidebarContent.js';

interface IFusePageCardedSidebarProps {
	open?: boolean;
	position?: 'left' | 'top' | 'right' | 'bottom' | undefined;
	variant?: string;
	onClose?: (val?: boolean) => void;
	content: ReactNode;
	rootRef?: any;
}

const FusePageCardedSidebar = forwardRef<any, IFusePageCardedSidebarProps>((props, ref) => {
	const { open = true, position, variant, onClose } = props;

	const [isOpen, setIsOpen] = useState(open);

	useImperativeHandle(ref, () => ({
		toggleSidebar: handleToggleDrawer,
	}));

	const handleToggleDrawer = useCallback((val: boolean) => {
		setIsOpen(val);
	}, []);

	useEffect(() => {
		handleToggleDrawer(open);
	}, [handleToggleDrawer, open]);

	return (
		<>
			<Hidden lgUp={variant === 'permanent'}>
				<SwipeableDrawer
					variant="temporary"
					anchor={position}
					open={isOpen}
					onOpen={ev => {}}
					onClose={() => (onClose ? onClose() : {})}
					disableSwipeToOpen
					classes={{
						root: clsx('FusePageCarded-sidebarWrapper', variant),
						paper: clsx(
							'FusePageCarded-sidebar',
							variant,
							position === 'left' ? 'FusePageCarded-leftSidebar' : 'FusePageCarded-rightSidebar'
						),
					}}
					ModalProps={{
						keepMounted: true, // Better open performance on mobile.
					}}
					// container={rootRef.current}
					BackdropProps={{
						classes: {
							root: 'FusePageCarded-backdrop',
						},
					}}
					style={{ position: 'absolute' }}
				>
					<FusePageCardedSidebarContent {...props} />
				</SwipeableDrawer>
			</Hidden>
			{variant === 'permanent' && (
				<Hidden lgDown>
					<Drawer
						variant="permanent"
						anchor={position}
						className={clsx(
							'FusePageCarded-sidebarWrapper',
							variant,
							isOpen ? 'opened' : 'closed',
							position === 'left' ? 'FusePageCarded-leftSidebar' : 'FusePageCarded-rightSidebar'
						)}
						open={isOpen}
						onClose={() => (onClose ? onClose() : {})}
						classes={{
							paper: clsx('FusePageCarded-sidebar', variant),
						}}
					>
						<FusePageCardedSidebarContent {...props} />
					</Drawer>
				</Hidden>
			)}
		</>
	);
});

export default FusePageCardedSidebar;
